using System;
using System.Collections.Generic;
using System.Text;

namespace AionDPS
{
    public abstract class SingletonBase<T> where T : class, new()
    {
        private static object lockObject = new object();
        private static T instance;
        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new T();
                        }
                    }
                }
                return instance;
            }
        }
    }
}
