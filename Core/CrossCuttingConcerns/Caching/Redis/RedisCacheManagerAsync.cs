using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Newtonsoft.Json;
using ServiceStack.Model;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;
using ServiceStack.Redis.Pipeline;

namespace Core.CrossCuttingConcerns.Caching.Redis
{
	/// <summary>
	/// RedisCacheManager
	/// </summary>
	public class RedisCacheManagerAsync : IRedisClientAsync
	{
		public IHasNamed<IRedisListAsync> Lists => throw new NotImplementedException();

		public IHasNamed<IRedisSetAsync> Sets => throw new NotImplementedException();

		public IHasNamed<IRedisSortedSetAsync> SortedSets => throw new NotImplementedException();

		public IHasNamed<IRedisHashAsync> Hashes => throw new NotImplementedException();

		public long Db => throw new NotImplementedException();

		public string Host => throw new NotImplementedException();

		public int Port => throw new NotImplementedException();

		public int ConnectTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int RetryTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int RetryCount { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public int SendTimeout { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
		public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

		public bool HadExceptions => throw new NotImplementedException();

		public ValueTask<IAsyncDisposable> AcquireLockAsync(string key, TimeSpan? timeOut = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> AddAsync<T>(string key, T value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> AddAsync<T>(string key, T value, DateTime expiresAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> AddAsync<T>(string key, T value, TimeSpan expiresIn, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> AddGeoMemberAsync(string key, double longitude, double latitude, string member, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> AddGeoMembersAsync(string key, RedisGeo[] geoPoints, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> AddGeoMembersAsync(string key, params RedisGeo[] geoPoints)
		{
			throw new NotImplementedException();
		}

		public ValueTask AddItemToListAsync(string listId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask AddItemToSetAsync(string setId, string item, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddItemToSortedSetAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddItemToSortedSetAsync(string setId, string value, double score, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask AddRangeToListAsync(string listId, List<string> values, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask AddRangeToSetAsync(string setId, List<string> items, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddRangeToSortedSetAsync(string setId, List<string> values, double score, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddRangeToSortedSetAsync(string setId, List<string> values, long score, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddToHyperLogAsync(string key, string[] elements, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> AddToHyperLogAsync(string key, params string[] elements)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> AppendToValueAsync(string key, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IRedisTypedClientAsync<T> As<T>()
		{
			throw new NotImplementedException();
		}

		public ValueTask BackgroundRewriteAppendOnlyFileAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask BackgroundSaveAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> BlockingDequeueItemFromListAsync(string listId, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<ItemRef> BlockingDequeueItemFromListsAsync(string[] listIds, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> BlockingPopAndPushItemBetweenListsAsync(string fromListId, string toListId, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> BlockingPopItemFromListAsync(string listId, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<ItemRef> BlockingPopItemFromListsAsync(string[] listIds, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> BlockingRemoveStartFromListAsync(string listId, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<ItemRef> BlockingRemoveStartFromListsAsync(string[] listIds, TimeSpan? timeOut, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> CalculateDistanceBetweenGeoMembersAsync(string key, string fromMember, string toMember, string unit = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> CalculateSha1Async(string luaBody, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> ContainsKeyAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> CountHyperLogAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IRedisPipelineAsync CreatePipeline()
		{
			throw new NotImplementedException();
		}

		public ValueTask<IRedisSubscriptionAsync> CreateSubscriptionAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IRedisTransactionAsync> CreateTransactionAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> CustomAsync(object[] cmdWithArgs, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> CustomAsync(params object[] cmdWithArgs)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> DbSizeAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<long> DecrementAsync(string key, uint amount, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> DecrementValueAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> DecrementValueByAsync(string key, int count, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAllAsync<TEntity>(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task DeleteAsync<T>(T entity, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task DeleteByIdAsync<T>(object id, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task DeleteByIdsAsync<T>(ICollection ids, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> DequeueItemFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask DisposeAsync()
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> EchoAsync(string text, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask EnqueueItemOnListAsync(string listId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<T> ExecCachedLuaAsync<T>(string scriptBody, Func<string, ValueTask<T>> scriptSha1, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaAsIntAsync(string luaBody, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaAsIntAsync(string luaBody, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaAsIntAsync(string luaBody, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaAsListAsync(string luaBody, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaAsListAsync(string luaBody, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaAsListAsync(string luaBody, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaAsStringAsync(string luaBody, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaAsStringAsync(string luaBody, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaAsStringAsync(string luaBody, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaAsync(string body, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaAsync(string body, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaAsync(string luaBody, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaShaAsIntAsync(string sha1, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaShaAsIntAsync(string sha1, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> ExecLuaShaAsIntAsync(string sha1, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaShaAsListAsync(string sha1, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaShaAsListAsync(string sha1, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> ExecLuaShaAsListAsync(string sha1, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaShaAsStringAsync(string sha1, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaShaAsStringAsync(string sha1, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> ExecLuaShaAsStringAsync(string sha1, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaShaAsync(string sha1, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaShaAsync(string sha1, params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> ExecLuaShaAsync(string sha1, string[] keys, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> ExpireEntryAtAsync(string key, DateTime expireAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> ExpireEntryInAsync(string key, TimeSpan expireIn, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string[]> FindGeoMembersInRadiusAsync(string key, double longitude, double latitude, double radius, string unit, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string[]> FindGeoMembersInRadiusAsync(string key, string member, double radius, string unit, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<RedisGeoResult>> FindGeoResultsInRadiusAsync(string key, double longitude, double latitude, double radius, string unit, int? count = null, bool? sortByNearest = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<RedisGeoResult>> FindGeoResultsInRadiusAsync(string key, string member, double radius, string unit, int? count = null, bool? sortByNearest = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task FlushAllAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask FlushDbAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask ForegroundSaveAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<IDictionary<string, T>> GetAllAsync<T>(IEnumerable<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, string>> GetAllEntriesFromHashAsync(string hashId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetAllItemsFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetAllItemsFromSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetAllItemsFromSortedSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetAllItemsFromSortedSetDescAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetAllKeysAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetAllWithScoresFromSortedSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetAndSetValueAsync(string key, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetAsync<T>(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<T> GetByIdAsync<T>(object id, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<IList<T>> GetByIdsAsync<T>(ICollection ids, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetClientAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<Dictionary<string, string>>> GetClientsInfoAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetConfigAsync(string item, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetDifferencesFromSetAsync(string fromSetId, string[] withSetIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetDifferencesFromSetAsync(string fromSetId, params string[] withSetIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisKeyType> GetEntryTypeAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<T> GetFromHashAsync<T>(object id, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<RedisGeo>> GetGeoCoordinatesAsync(string key, string[] members, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<RedisGeo>> GetGeoCoordinatesAsync(string key, params string[] members)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string[]> GetGeohashesAsync(string key, string[] members, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string[]> GetGeohashesAsync(string key, params string[] members)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetHashCountAsync(string hashId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetHashKeysAsync(string hashId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetHashValuesAsync(string hashId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetIntersectFromSetsAsync(string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetIntersectFromSetsAsync(params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetItemFromListAsync(string listId, int listIndex, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetItemIndexInSortedSetAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetItemIndexInSortedSetDescAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> GetItemScoreInSortedSetAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IAsyncEnumerable<string> GetKeysByPatternAsync(string pattern, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetListCountAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetRandomItemFromSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetRandomKeyAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromListAsync(string listId, int startingFrom, int endingAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedListAsync(string listId, int startingFrom, int endingAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetAsync(string setId, int fromRank, int toRank, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, string fromStringScore, string toStringScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, string fromStringScore, string toStringScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, double fromScore, double toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByHighestScoreAsync(string setId, long fromScore, long toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, string fromStringScore, string toStringScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, string fromStringScore, string toStringScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, double fromScore, double toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetByLowestScoreAsync(string setId, long fromScore, long toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetRangeFromSortedSetDescAsync(string setId, int fromRank, int toRank, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetAsync(string setId, int fromRank, int toRank, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, string fromStringScore, string toStringScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, string fromStringScore, string toStringScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, double fromScore, double toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByHighestScoreAsync(string setId, long fromScore, long toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, string fromStringScore, string toStringScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, string fromStringScore, string toStringScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, double fromScore, double toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetByLowestScoreAsync(string setId, long fromScore, long toScore, int? skip, int? take, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<IDictionary<string, double>> GetRangeWithScoresFromSortedSetDescAsync(string setId, int fromRank, int toRank, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisServerRole> GetServerRoleAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<RedisText> GetServerRoleInfoAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<DateTime> GetServerTimeAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetSetCountAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<SlowlogItem[]> GetSlowlogAsync(int? numberOfRecords = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetSortedEntryValuesAsync(string key, int startingFrom, int endingAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetSortedItemsFromListAsync(string listId, SortOptions sortOptions, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetSortedSetCountAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetSortedSetCountAsync(string setId, string fromStringScore, string toStringScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetSortedSetCountAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetSortedSetCountAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> GetStringCountAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<TimeSpan?> GetTimeToLiveAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetUnionFromSetsAsync(string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<HashSet<string>> GetUnionFromSetsAsync(params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetValueAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> GetValueFromHashAsync(string hashId, string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetValuesAsync(List<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<T>> GetValuesAsync<T>(List<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetValuesFromHashAsync(string hashId, string[] keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> GetValuesFromHashAsync(string hashId, params string[] keys)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, string>> GetValuesMapAsync(List<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, T>> GetValuesMapAsync<T>(List<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> HashContainsEntryAsync(string hashId, string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> HasLuaScriptAsync(string sha1Ref, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<long> IncrementAsync(string key, uint amount, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> IncrementItemInSortedSetAsync(string setId, string value, double incrementBy, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> IncrementItemInSortedSetAsync(string setId, string value, long incrementBy, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> IncrementValueAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> IncrementValueByAsync(string key, int count, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> IncrementValueByAsync(string key, long count, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> IncrementValueByAsync(string key, double count, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> IncrementValueInHashAsync(string hashId, string key, int incrementBy, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<double> IncrementValueInHashAsync(string hashId, string key, double incrementBy, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, string>> InfoAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask KillClientAsync(string address, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> KillClientsAsync(string fromAddress = null, string withId = null, RedisClientType? ofType = null, bool? skipMe = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask KillRunningLuaScriptAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<DateTime> LastSaveAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> LoadLuaScriptAsync(string body, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask MergeHyperLogsAsync(string toKey, string[] fromKeys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask MergeHyperLogsAsync(string toKey, params string[] fromKeys)
		{
			throw new NotImplementedException();
		}

		public ValueTask MoveBetweenSetsAsync(string fromSetId, string toSetId, string item, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask PauseAllClientsAsync(TimeSpan duration, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> PingAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> PopAndPushItemBetweenListsAsync(string fromListId, string toListId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> PopItemFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> PopItemFromSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> PopItemsFromSetAsync(string setId, int count, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> PopItemWithHighestScoreFromSortedSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> PopItemWithLowestScoreFromSortedSetAsync(string setId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask PrependItemToListAsync(string listId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask PrependRangeToListAsync(string listId, List<string> values, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> PublishMessageAsync(string toChannel, string message, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask PushItemToListAsync(string listId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task RemoveAllAsync(IEnumerable<string> keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask RemoveAllFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask RemoveAllLuaScriptsAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> RemoveAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task RemoveByPatternAsync(string pattern, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task RemoveByRegexAsync(string regex, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> RemoveEndFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> RemoveEntryAsync(string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> RemoveEntryAsync(params string[] args)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> RemoveEntryFromHashAsync(string hashId, string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task RemoveExpiredEntriesAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveItemFromListAsync(string listId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveItemFromListAsync(string listId, string value, int noOfMatches, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask RemoveItemFromSetAsync(string setId, string item, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> RemoveItemFromSortedSetAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveItemsFromSortedSetAsync(string setId, List<string> values, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveRangeFromSortedSetAsync(string setId, int minRank, int maxRank, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveRangeFromSortedSetByScoreAsync(string setId, double fromScore, double toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveRangeFromSortedSetByScoreAsync(string setId, long fromScore, long toScore, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> RemoveRangeFromSortedSetBySearchAsync(string setId, string start = null, string end = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> RemoveStartFromListAsync(string listId, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask RenameKeyAsync(string fromName, string toName, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ReplaceAsync<T>(string key, T value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ReplaceAsync<T>(string key, T value, DateTime expiresAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> ReplaceAsync<T>(string key, T value, TimeSpan expiresIn, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask ResetInfoStatsAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SaveConfigAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IAsyncEnumerable<KeyValuePair<string, string>> ScanAllHashEntriesAsync(string hashId, string pattern = null, int pageSize = 1000, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IAsyncEnumerable<string> ScanAllKeysAsync(string pattern = null, int pageSize = 1000, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IAsyncEnumerable<string> ScanAllSetItemsAsync(string setId, string pattern = null, int pageSize = 1000, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public IAsyncEnumerable<KeyValuePair<string, double>> ScanAllSortedSetItemsAsync(string setId, string pattern = null, int pageSize = 1000, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> SearchKeysAsync(string pattern, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<List<string>> SearchSortedSetAsync(string setId, string start = null, string end = null, int? skip = null, int? take = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> SearchSortedSetCountAsync(string setId, string start = null, string end = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SelectAsync(long db, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetAllAsync(IEnumerable<string> keys, IEnumerable<string> values, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetAllAsync(IDictionary<string, string> map, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task SetAllAsync<T>(IDictionary<string, T> values, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> SetAsync<T>(string key, T value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> SetAsync<T>(string key, T value, DateTime expiresAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<bool> SetAsync<T>(string key, T value, TimeSpan expiresIn, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetClientAsync(string name, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetConfigAsync(string item, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SetContainsItemAsync(string setId, string item, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SetEntryInHashAsync(string hashId, string key, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SetEntryInHashIfNotExistsAsync(string hashId, string key, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetItemInListAsync(string listId, int listIndex, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetRangeInHashAsync(string hashId, IEnumerable<KeyValuePair<string, string>> keyValuePairs, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetValueAsync(string key, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetValueAsync(string key, string value, TimeSpan expireIn, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SetValueIfExistsAsync(string key, string value, TimeSpan? expireIn = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SetValueIfNotExistsAsync(string key, string value, TimeSpan? expireIn = null, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SetValuesAsync(IDictionary<string, string> map, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask ShutdownAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask ShutdownNoSaveAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask SlowlogResetAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<bool> SortedSetContainsItemAsync(string setId, string value, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task StoreAllAsync<TEntity>(IEnumerable<TEntity> entities, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreAsHashAsync<T>(T entity, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public Task<T> StoreAsync<T>(T entity, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreDifferencesFromSetAsync(string intoSetId, string fromSetId, string[] withSetIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreDifferencesFromSetAsync(string intoSetId, string fromSetId, params string[] withSetIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreIntersectFromSetsAsync(string intoSetId, string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreIntersectFromSetsAsync(string intoSetId, params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreIntersectFromSortedSetsAsync(string intoSetId, string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreIntersectFromSortedSetsAsync(string intoSetId, params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreIntersectFromSortedSetsAsync(string intoSetId, string[] setIds, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<object> StoreObjectAsync(object entity, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreUnionFromSetsAsync(string intoSetId, string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask StoreUnionFromSetsAsync(string intoSetId, params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreUnionFromSortedSetsAsync(string intoSetId, string[] setIds, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreUnionFromSortedSetsAsync(string intoSetId, params string[] setIds)
		{
			throw new NotImplementedException();
		}

		public ValueTask<long> StoreUnionFromSortedSetsAsync(string intoSetId, string[] setIds, string[] args, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask TrimListAsync(string listId, int keepStartingFrom, int keepEndingAt, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<string> TypeAsync(string key, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask UnWatchAsync(CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public string UrnKey<T>(T value)
		{
			throw new NotImplementedException();
		}

		public string UrnKey<T>(object id)
		{
			throw new NotImplementedException();
		}

		public string UrnKey(Type type, object id)
		{
			throw new NotImplementedException();
		}

		public ValueTask WatchAsync(string[] keys, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask WatchAsync(params string[] keys)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, bool>> WhichLuaScriptsExistsAsync(string[] sha1Refs, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}

		public ValueTask<Dictionary<string, bool>> WhichLuaScriptsExistsAsync(params string[] sha1Refs)
		{
			throw new NotImplementedException();
		}

		public ValueTask WriteAllAsync<TEntity>(IEnumerable<TEntity> entities, CancellationToken token = default)
		{
			throw new NotImplementedException();
		}
	}
}