using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SignletonPattern
{
    // Singleton Pattern ensures a class has only one instance and provides a global point of access to it.
    public sealed class Singleton
    {
        private static Singleton? _instance;

        private Singleton()
        {

        }
        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }
                return _instance;
            }
        }

        public void SomeBusinessLogic() => Console.WriteLine("SomeBusinessLogic method called");
    }


    //Before lazy how we handled thread safety using lock

    public sealed class SingletonWithLock
    {
        private static SingletonWithLock? _instance;
        private static readonly object _lock = new object();
        private SingletonWithLock()
        {

        }
        public static SingletonWithLock Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new SingletonWithLock();
                        }
                    }
                }
                return _instance;
            }
        }

        public void SomeBusinessLogic() => Console.WriteLine("SomeBusinessLogic method called");
    }


    // Lazy Initialization, it will help thread safety

    public sealed class SingletonWithLazy
    {
        private static readonly Lazy<SingletonWithLazy> _instance = new Lazy<SingletonWithLazy>(() => new SingletonWithLazy());

        private SingletonWithLazy()
        {

        }
        public static SingletonWithLazy Instance => _instance.Value;

        public void SomeBusinessLogic() => Console.WriteLine("SomeBusinessLogic method called");
    }

    // Generic way of creating

    public sealed class SingletonGeneric<T> where T : new()
    {
        private static readonly Lazy<T> _instance =
            new(() => new T());

        public static T Instance => _instance.Value;

        private SingletonGeneric() { }

        public void SomeBusinessLogic() => Console.WriteLine("SomeBusinessLogic method called");
    }
}
