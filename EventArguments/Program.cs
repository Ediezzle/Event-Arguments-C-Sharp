using System;

namespace EventArguments
{
    class Program
    {
        static void Main(string[] args)
        {
            Number myNumber = new Number(100000);
            myNumber.PrintMoney();
            myNumber.PrintNumber();
        }
    }
}
