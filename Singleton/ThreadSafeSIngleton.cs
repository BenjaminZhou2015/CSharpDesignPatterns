using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class ThreadSafeSingleton
    {
        private static ThreadSafeSingleton _instance;
        private static object o = new object();
        private ThreadSafeSingleton()
        {
        }

        /// <summary>
        /// alternative
        /// </summary>
        /// <returns></returns>
        public static ThreadSafeSingleton GetInstance()
        {

            if (_instance == null)
            {
                lock (o)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }
            return _instance;
        }

    }
}
