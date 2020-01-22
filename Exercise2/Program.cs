using System;

namespace Exercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 23;
            int height = 180;
            //Max heart rate = 220 - age
            //I am xxx years old and my max heart rate is xxx and I am xx inches tall.
            int heartrate = 220 - age;
            Console.WriteLine("I am "+age+ " years old and my maximum heart rate is "+heartrate+" and I am "+height+" inches tall");
        }
    }
}
