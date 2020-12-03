using System;
using System.IO;



namespace Hometask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********  Home Task 2/ Read lines from file csv  ********\n");
            string path = @"D:\study\Garanin\Hometask2\hometask.csv";
           
                using (StreamReader sr = new StreamReader(path))
                {
                    // Console.WriteLine(sr.ReadToEnd());
                    string line;
                    while ((line =sr.ReadLine()) != null)
                    {
                        Console.WriteLine(line);
                        //Console.WriteLine("\n");
                    }
                }
           
            
        }
    }
}
