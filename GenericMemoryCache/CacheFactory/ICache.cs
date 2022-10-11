namespace GenericMemoryCache.CacheFactory
{
    public interface ICache
    {
        string CacheType();
        public T GetData<T>(string key);
        public void SetData<T>(string key, T value, DateTimeOffset expriationTime);
        public void RemoveData(string key);
    }
}
