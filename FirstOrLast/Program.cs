using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kusib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendes on pikem, kas ees-voi perekonnanimi

            Console.WriteLine("sisesta eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("sisesta perekonnanimi:");
            string lastName = Console.ReadLine();
            int firstNameLength = firstName.Length;
            int lastNameLength = lastName.Length;
            Console.WriteLine($"Sinu eesnimes on {firstNameLength} sumbolit. Perekonnanimes on {lastNameLength} sumbolit");

            if (firstNameLength < lastNameLength)
            {
                Console.WriteLine("Perekonnanimi on pikem, kui eesnimi");

            }
            if (firstNameLength > lastNameLength)
            {
                Console.WriteLine("Eesnimi on pikem, kui perekonnanimi");
            }
            else if (firstNameLength == lastNameLength)
          {
                Console.WriteLine("Ees- ja perekonnanimi on vordsed");
            }
            
               
        

        }
    }
}
