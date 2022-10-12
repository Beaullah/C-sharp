using System;

namespace myCpractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //    OUTPUTS
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("I love pizza");
            // Console.WriteLine("hello!");
            // use for comment
            // Console.WriteLine("\tBonita"); // on a tab
            //Console.WriteLine("Bonita\nFummey"); // on a new line
            //Console.ReadKey();// enter before the programs stops

            // Viarables


            // int a; // decleration
            // a = 12; // initialize
            // int y = 12;
            // int age = 21;
            //string name = "hey how are you";
            //Console.WriteLine(name);
            // Console.WriteLine("your age is " + age + "years old");
            // Console.WriteLine(a);
            //Console.WriteLine(y);
            // bool true or false
            // double takes decimal
            // char a single char

            // Conversion

            // double y = 23.4;
            // int a = Convert.ToInt32(y);
            // int d = 2;
            // int e = 123;
            // string i = Convert.ToString(e);
            // Console.WriteLine(e);
            // Console.WriteLine(e.GetType());
            // Console.WriteLine(a.GetType());
            // Console.WriteLine(a);
            // Console.ReadKey();
            // User input

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Hello," + name);

            Console.WriteLine("What is your age");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Hello," + age);


        }
    }
}
