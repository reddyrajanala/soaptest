using System;

namespace SoapRequestTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Run test!");

            var soapHelper = new SoapHelper();

            var rate = soapHelper.GetRate();

            Console.WriteLine($"Rate is {rate}");

            Console.ReadKey();


        }
    }
}
