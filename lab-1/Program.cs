// See https://aka.ms/new-console-template for more information

using queue;


var example = new queue.Queue<int>();

example.Add(3);
example.Add(2);
example.Add(1);


Console.WriteLine(example.GetElement());
Console.WriteLine(example.GetElement());
Console.WriteLine(example.GetElement());
Console.WriteLine(example.GetElement());