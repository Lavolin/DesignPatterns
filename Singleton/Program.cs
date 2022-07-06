using System;
using System.Threading;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var thread = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    UserSingleton.Instance.SayHi();

                }

            });

            var thread2 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    UserSingleton.Instance.SayHi();

                }
            });

            var thread3 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    UserSingleton.Instance.SayHi();

                }
            });

            var thread4 = new Thread(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    UserSingleton.Instance.SayHi();

                }
            });

            thread.Start();
            thread2.Start();
            thread3.Start();
            thread4.Start();
            //UserSingleton.Instance.SayHi();

            //UserSingleton.Instance.SayHi();
            //UserSingleton.Instance.Name = "tosho";
        }
    }
}
