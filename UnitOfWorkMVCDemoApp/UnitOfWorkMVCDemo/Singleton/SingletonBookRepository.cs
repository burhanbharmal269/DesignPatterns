using UnitOfWorkMVCDemo.Models;

namespace UnitOfWorkMVCDemo.Singleton
{
    public class SingletonBookRepository
    {
        private SingletonBookRepository()
        {}

        private static object locker = new object();
        public static SingletonBookRepository _instance;

        public static SingletonBookRepository GetInstance()
        {
            if (_instance == null)
            {
                //This is known as double check locking, to stop user from making insatnce at one time
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonBookRepository();
                    }
                }
            }
            return _instance;
        }

    }
}
