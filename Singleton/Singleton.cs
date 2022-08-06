using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class Singleton
    {
        private static Singleton _instance = new Singleton();
        private Singleton()
        {
        }
        public static Singleton Instance
        {
            get
            {
                return _instance;
            }
        }

        //public static Singleton GetSingleton()
        //{
        //    return _instance;
        //}
    }
}
