using System;

namespace HOLCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab konsoolis, mitu "h","o" ja "l" tahte on lauses "Hello World!"

            
            string lause = "Hello World!".ToLower();
            int hCounter = 0;
            for (int i = 0; i < lause.Length; i++)
            {
               if(lause[i] == 'h')
                {
                    hCounter++;
                }
            }
            int oCounter = 0;
            for (int i = 0; i < lause.Length; i++)
            {
                if(lause[i] == 'o')
                {
                    oCounter++;
                }
            }
                int lCounter = 0;
            for (int i = 0; i < lause.Length; i++)
            {
                if(lause[i] == 'l')
                {
                    lCounter++;
                }

                
                
            }
            if ( hCounter != 1)
                {
                Console.Write($"Lauses Hello World! on {hCounter} 'h' tahte");
            }
           
           else
            {
                Console.Write($"Lauses Hello World! on {hCounter} 'h' taht");
            }
            
            if(oCounter != 1)
            {
                Console.Write($", {oCounter} 'o' tahte");
            }
            else
            {
                Console.Write($", {oCounter} 'o' taht");
            }
            if(lCounter != 1)
            {
                Console.Write($", {lCounter} 'l' tahte.");
            }
            else
            {
                Console.Write($", {lCounter} 'l' taht.");
            }

        }
    }
}
