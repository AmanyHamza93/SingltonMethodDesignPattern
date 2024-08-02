using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingltonMethodDesignPattern
{
    public class Singleton
    {
        private static Singleton? instance;
        private static object objLock = new object();
        private Singleton()
        {
            
        }
        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock(objLock)
                {
                    // Lazy Initalization
                    instance = new Singleton();
                }
            }
            return instance;
        }
    }
}
