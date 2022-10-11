namespace GenericMemoryCache.CacheFactory
{
    public class Redis : ICache
    {
        public string CacheType()
        {
            return "redis";
        }

        public T GetData<T>(string key)
        {
            throw new NotImplementedException();
        }

        public void RemoveData(string key)
        {
            throw new NotImplementedException();
        }

        public void SetData<T>(string key, T value, DateTimeOffset expriationTime)
        {
            throw new NotImplementedException();
        }
    }
}
