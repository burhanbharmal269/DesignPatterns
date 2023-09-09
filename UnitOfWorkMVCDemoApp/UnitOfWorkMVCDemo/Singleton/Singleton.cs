namespace UnitOfWorkMVCDemo.Singleton
{
    class Singleton
    {
        //Private Constructor so cannot make instance 
        private Singleton(){}
        private static object locker = new object();

        private static Singleton _instance;
        public static Singleton GetInstance()
        {
            if (_instance == null)
            {
                //This is known as double check locking, to stop user from making insatnce at one time
                lock (locker)
                {
                    if (_instance == null)
                    {
                        _instance = new Singleton();
                    }
                }
            }
            
            return _instance;
        }
    }
}
