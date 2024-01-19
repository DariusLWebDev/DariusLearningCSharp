using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DariusLearningCSharp
{
    class Methods
    {
        static void MyMethod()
        {
            Console.WriteLine("I just got executed");
        }

        static void Branch(string[] args)
        {
            MyMethod();
        }
    }
}
