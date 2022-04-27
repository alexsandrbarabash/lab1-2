// See https://aka.ms/new-console-template for more information

using queue;
using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    class Program
    {
        static void Main(string[] args)
        {
            var example = new queue.Queue<int>();
            var main = new MainService();
            example.Added += main.OnAdded;
            example.Add(3);
            example.Add(2);
            example.Add(1);
            Console.WriteLine(example.GetElement());
            Console.WriteLine(example.GetElement());
            Console.WriteLine(example.GetElement());
            Console.WriteLine(example.GetElement());
        }
    }

    public class MainService
    {
        public void OnAdded(int value)
        {
            Console.WriteLine("Add");
            Console.WriteLine(value);
        }
    }
}