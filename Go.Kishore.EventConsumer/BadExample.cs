namespace Go.Kishore.EventConsumer
{
    
using System;
using System.Collections.Generic;

public class BadExample
{
    private readonly static myName;
    public void CheckCode(string[] args)
        {
            var numbers = new List<int>();
            numbers.Add(1);
            numbers.Add(2);
            numbers.Add(3);

            Console.WriteLine("myName: " + myName);


            // ❌ Bug 1: Division by zero (runtime error)
            int result = 10 / (numbers.Count - 3);
            Console.WriteLine("Result: " + result);

            // ❌ Bug 2: Null reference risk
            string name = null;
            Console.WriteLine("Name length: " + name.Length);

            // ❌ Bug 3: Index out of range
            Console.WriteLine("Fourth element: " + numbers[3]);

            // ❌ Bug 4: Unused variable
            int unused = 42;

            // ❌ Bug 5: Hardcoded credentials
            string connectionString = "Server=localhost;User=admin;Password=12345;";
            Console.WriteLine("Connecting to DB with: " + connectionString);
        }
}
}


