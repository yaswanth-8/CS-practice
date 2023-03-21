using System;
using System.Reflection.Metadata.Ecma335;

namespace HelloWorld
{
    class Program
    {
       
        static void Main(string[] args)
        {
            int a = 5;
            check(ref a);
            Console.WriteLine(a);
        }
        static void check(ref int a)
        {
            a++;
        }
        //pulled from github -1
        //pushing to github from vs
    }
}
