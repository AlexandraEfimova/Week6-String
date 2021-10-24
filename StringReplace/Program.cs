using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "hello world!" tarniga (*)

            string hellow = "Hello World!";

            

            hellow = hellow.Replace('o', '*');
            hellow = hellow.Replace('!', '1');
            Console.WriteLine(hellow);
        }
    }
}
