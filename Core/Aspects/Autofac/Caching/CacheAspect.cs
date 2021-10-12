using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Castle.DynamicProxy;
using Core.CrossCuttingConcerns.Caching;
using Core.Entities.Dtos;
using Core.Utilities.Interceptors;
using Core.Utilities.IoC;
using Core.Utilities.Results;
using Microsoft.Extensions.DependencyInjection;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;

namespace Core.Aspects.Autofac.Caching
{
    /// <summary>
    /// CacheAspect
    /// </summary>
    public class CacheAspect : MethodInterception
    {
        private readonly int _duration;
        private readonly ICacheManager _cacheManager;
        private Type type;

        public CacheAspect(int duration = 60, Type type = null)
        {
            this.type = type;
            _duration = duration;
            _cacheManager = ServiceTool.ServiceProvider.GetService<ICacheManager>();
        }

        public override void Intercept(IInvocation invocation)
        {
            
            var methodName = string.Format($"{invocation.Arguments[0]}.{invocation.Method.Name}");
            var arguments = invocation.Arguments;
            var key = $"{methodName}({BuildKey(arguments)})";

            var task = _cacheManager.IsAdd(key);
            task.Wait();
            
            if (task.Result)
            {
                dynamic data = _cacheManager.Get(key).Result;
                if (data is string)
                {
                    var settings = new JsonSerializerSettings
                    {
                        Formatting = Newtonsoft.Json.Formatting.Indented,
                        TypeNameHandling = TypeNameHandling.Auto,
                        
                    };
                    var data2 = JsonConvert.DeserializeAnonymousType(data,type);
                    invocation.ReturnValue = data2;
                    return;
                    
                }

                invocation.ReturnValue = data;
                return;
            }

            invocation.Proceed();

            if (invocation.ReturnValue is Task)
            {
                var data = Convert((Task)invocation.ReturnValue);
                var str = Newtonsoft.Json.JsonConvert.SerializeObject(data);
                _cacheManager.Add(key, str);
                return;

            }

            _cacheManager.Add(key, invocation.ReturnValue);
        }


        string BuildKey(object[] args)
        {
            var sb = new StringBuilder();
            foreach (var arg in args)
            {
                var paramValues = arg.GetType().GetProperties()
                    .Select(p => p.GetValue(arg)?.ToString() ?? string.Empty);
                sb.Append(string.Join('_', paramValues));
            }

            return sb.ToString();
        }

        private  dynamic Convert(Task task)
        {
            var voidTaskType = typeof(Task<>).MakeGenericType(Type.GetType("System.Threading.Tasks.VoidTaskResult"));
            if (voidTaskType.IsAssignableFrom(task.GetType()))
                throw new InvalidOperationException("Task does not have a return value (" + task.GetType().ToString() + ")");
            var property = task.GetType().GetProperty("Result", BindingFlags.Public | BindingFlags.Instance);
            if (property == null)
                throw new InvalidOperationException("Task does not have a return value (" + task.GetType().ToString() + ")");
            return property.GetValue(task);
        }
    }
}