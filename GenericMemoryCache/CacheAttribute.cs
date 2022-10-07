namespace GenericMemoryCache
{
    [AttributeUsage(AttributeTargets.All)]
    public class CacheAttribute :Attribute {

        private string _methodName;
        private string _cacheType;

        public CacheAttribute(string MethodName, string CacheType)
        {
         _methodName = MethodName;
         _cacheType = CacheType;
         
        }

        public string MethodName { get => _methodName; }
        public string CacheType { get => _cacheType;  }
    }  
  
}
