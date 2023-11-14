namespace BundleShop.Core
{
    public class Singleton<T> where T : Singleton<T>
    {
        private static T _instance;

        protected Singleton()
        {
            _instance = this as T;
        }
        
        public static T Instance
        {
            get
            {
                return _instance;
            }
        }
    }
}