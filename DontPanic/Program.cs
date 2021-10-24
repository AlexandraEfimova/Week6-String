using System;

namespace DontPanic
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm asendab koik 'o' tahed lauses "Don't Panic" nulliga - 0
            //programm asendab koik 'a' tahed lauses "Don't Panic" neljaga

            string dontp = "Don't Panic";



            dontp = dontp.Replace('o', '0');
            dontp = dontp.Replace('a', '4');
            Console.WriteLine(dontp);
        }
    }
}
