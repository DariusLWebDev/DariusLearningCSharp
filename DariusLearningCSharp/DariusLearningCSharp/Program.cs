using System;

namespace DariusLearningCSharp
{
    class Program
    {
        //This is a comment
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("I am Learning C#"); //This is a comment
            Console.WriteLine("It is awesome");
            Console.WriteLine(3 + 3);
            /* The code below will print the words Hello World
               to the screen, and it is amazing */
            Console.Write("Hello World ");
            Console.Write("I will print on the same line ");

            //Learning Variables
            string name = "John";
            Console.WriteLine(name);

            int myNum = 15;
            Console.WriteLine(myNum);

            int myNumb2;
            myNumb2 = 15;
            Console.WriteLine(myNumb2);

            int myNumb3 = 15;
            myNumb3 = 20;
            Console.WriteLine(myNumb3);

            double myDec = 5;
            Console.WriteLine(myDec);

            char myLetter = 'A';
            Console.WriteLine(myLetter);

            bool myBool = false;
            Console.WriteLine(myBool);

            string myText = "Hello";
            Console.WriteLine(myText);

            //Constants
            const int myNumb5 = 5;
            //myNumb5 = 20; error
            Console.WriteLine(myNumb5);

            //Display Variables
            string firstName = "Darius";
            Console.WriteLine("Hello " + firstName);

            string firstName2 = "Darius ";
            string lastName2 = "Lolong";
            string fullName = firstName2 + lastName2;
            Console.WriteLine(fullName);

            int x = 5;
            int y = 10;
            Console.WriteLine(x + y);

            //Declare Many Variables
            int a = 5, b = 10, c = 10;
            Console.WriteLine(a + b + c);

            int d, e, f;
            d = e = f = 10;
            Console.WriteLine(d + e + f);

            double myNumb6 = 19.99;
            Console.WriteLine(myNumb6);

            float f1 = 35e3F;
            double d1 = 12E4D;
            Console.WriteLine(f1);
            Console.WriteLine(d1);

            //Booleans

            bool isCSharpFun = true;
            bool isFishTasty = false;
            Console.WriteLine(isCSharpFun);
            Console.WriteLine(isFishTasty);










        }
    }
}