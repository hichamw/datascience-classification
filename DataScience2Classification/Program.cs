using System;
using ConsoleApp1;

namespace DataScience2Classification
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            DataLoader dataLoader = new DataLoader();
            dataLoader.Load("../../../RetailMart.xlsx","Linear Model","../../../LinearModel.csv");
        }
    }
}