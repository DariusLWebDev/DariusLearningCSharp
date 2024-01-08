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

            //Type Casting

            int myInt = 9;
            double myDouble = myInt;

            Console.WriteLine(myInt);
            Console.WriteLine(myDouble);

            //Casting

            int myInt2 = 10;
            double myDouble2 = 5.25;
            bool myBool2 = true;

            Console.WriteLine(Convert.ToString(myInt2));
            Console.WriteLine(Convert.ToDouble(myInt2));
            Console.WriteLine(Convert.ToInt32(myDouble2));
            Console.WriteLine(Convert.ToString(myBool2));

            // User Input
            Console.WriteLine("Enter username:");
            string userName = Console.ReadLine();
            Console.WriteLine("Username is: " + userName);

            //Comparison

            int x2 = 5;
            int y2 = 3;
            Console.WriteLine(x2 < y2);

            Console.WriteLine(x2 > 1 && x2 < y2);

            string txt = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Console.WriteLine("The lenght of the txt string is: " + txt.Length);


            Console.WriteLine(txt.ToUpper());
            Console.WriteLine(txt.ToLower());

            string firstName3 = "John";
            string lastName = "Doe";
            string name2 = $"My full name is: {firstName3} {lastName}";
            Console.WriteLine(name2);

            //if...Else
            if (20 > 18)
            {
                Console.WriteLine("20 is greater than 18");
            }

            int time = 20;
            if (time < 18)
            {
                Console.WriteLine("Good Day");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

            int time2 = 22;
            if (time2 < 10)
            {
                Console.WriteLine("Good Day");
            }
            else if (time2 < 20) {
                Console.WriteLine("Good Morning");
            }
            else
            {
                Console.WriteLine("Good Evening");
            }

            //Shorthand

            int time3 = 20;
            string result = (time3 < 18) ? "Good day." : "Good evening";
            Console.WriteLine(result);

            //Switch

            int day = 9;
            switch (day)
            {
                case 1:
                Console.WriteLine("Monday");
                break;
                case 2:
                Console.WriteLine("Tuesday"); 
                break;
                case 3:
                Console.WriteLine("Wednesday");
                break;  
                case 4:
                Console.WriteLine("Thursday");
                break;
                case 5:
                Console.WriteLine("Friday");
                break;
                case 6:
                Console.WriteLine("Saturday");
                break;
                case 7:
                Console.WriteLine("Sunday");
                break;
                default: 
                Console.WriteLine("Looking forward to the Weekend");
                break;
            }

            //loops

            int i = 0;
            while (i < 10)
            {
                Console.WriteLine(i);
                i++;
            }

            int v = 0;
            do
            {
                Console.WriteLine(v);
                v++;
            }
            while (v < 10);


            for (int z = 0; z < 5; z++)
            {
                Console.WriteLine(z);
            }

            for (int g = 0; g <= 5; g = g + 1)
            {
                Console.WriteLine(g);
            }
            
        }
    }
}