using System;
using NUnit.Framework;
using queue;


namespace TestProject1;

public class Tests
{
    [Test]
    public void TestAdd()
    {
        var example = new queue.Queue<int>();
        example.Add(1);
        Assert.AreEqual(example.Length, 1);
    }

    [Test]
    public void GetCorrectElement()
    {
        var example = new queue.Queue<int>();
        example.Add(1);
        example.Add(2);
        example.Add(3);
        Assert.AreEqual(example.GetElement(), 1);
        Assert.AreEqual(example.GetElement(), 2);
        Assert.AreEqual(example.GetElement(), 3);
    }

    [Test]
    public void GetEmptyQueue()
    {
        var example = new queue.Queue<int>();
        Assert.Throws<InvalidOperationException>(() => example.GetElement());
    }
}