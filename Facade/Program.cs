using System;

namespace Facade
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            bank.DoTransaction();
        }
    }
}
