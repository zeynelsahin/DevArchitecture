using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using ServiceStack.Caching;
using ServiceStack.Redis;

namespace Core.CrossCuttingConcerns.Caching.Redis
{
	/// <summary>
	/// RedisCacheManager
	/// </summary>
	public class RedisCacheManager : ICacheManager
	{
		private readonly RedisEndpoint _redisEndpoint;
		private readonly IRedisClientsManagerAsync _manager;		

		public RedisCacheManager(IRedisClientsManagerAsync manager)
		{
			_redisEndpoint = new RedisEndpoint("localhost", 6379);
			_manager = manager;
			
		}

		public async Task<T> Get<T>(string key)
		{			
			await using var client = await _manager.GetClientAsync();
			var result = await client.GetAsync<T>(key);
			return result;
		}

		public async Task<object> Get(string key)
		{
			await using var client = await _manager.GetClientAsync();
			var result = await client.GetAsync<IEnumerable<string>>(key);
			return result;
		}

		public async Task Add(string key, object data, int duration)
		{
			try
			{
				await using var client = await _manager.GetClientAsync();

				var asd = await client.AddAsync(key, data, TimeSpan.FromMinutes(duration));
			}
			catch (Exception ex)
			{

				throw;
			}
			
		}

		public async Task Add(string key, object data)
		{
			try
			{
				await using var client = await _manager.GetClientAsync();
				await client.AddAsync(key, data);
			}
			catch (Exception ex )
			{

				throw;
			}
	
		}

		public async Task<bool> IsAdd(string key)
		{
			var isAdded = false;
			await using var client = await _manager.GetClientAsync();
			isAdded=await client.ContainsKeyAsync(key);			
			return isAdded;
		}

		public async Task Remove(string key)
		{
			await using var client = await _manager.GetClientAsync();
			await client.RemoveAsync(key);
		}

		public async Task RemoveByPattern(string pattern)
		{
			await using var client = await _manager.GetClientAsync();
			await client.RemoveByPatternAsync(pattern);			
		}

		public async Task Clear()
		{
			await using var client = await _manager.GetClientAsync();
			await client.FlushAllAsync();
		}

		//private void RedisInvoker(Action<RedisClient> redisAction)
		//{
		//	using (var client = new RedisClient(_redisEndpoint))
		//	{
		//		redisAction.Invoke(client);
		//	}
		//}
	}
}