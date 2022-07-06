using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Singleton
{
    class UserSingleton
    {
        private static UserSingleton instance;
        private static object lockObject = new object();
        private UserSingleton()
        {

        }
        public static UserSingleton Instance
        {

            get
            {
                if (instance == null)
                {
                    //Monitor.Enter(lockObject); - the same as lock
                    lock (lockObject) // заключва на повече от един тред да се върже към инстанцията
                    {
                        if (instance == null)
                        {
                            Console.WriteLine("Created new Singleton instance");
                            instance = new UserSingleton();
                        }
                    }
                    //Monitor.Exit(lockObject);
                }
                return instance;
            }
        }

        public string Name { get; set; }
        public string Permission { get; set; }

        public void SayHi()
        {
            //Console.WriteLine("Hi from singleton (only one instance)");
        }
    }
}
