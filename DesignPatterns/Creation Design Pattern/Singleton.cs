using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creation_Design_Pattern
{
    public sealed class Singleton
    {
        private static Singleton instance = null;
        private static readonly object instanceLock = new object();

        private Singleton()
        {

        }

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                lock (instanceLock)
                    instance = new Singleton();
            }
            return instance;
        }

        public void PrintMessage()
        {
            Console.WriteLine("Singleton Pattern");
        }
    }
}
