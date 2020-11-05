using System;

namespace SequenciaCentena
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
         int i ; 
         string Masc = "00.##";
         Console.WriteLine("      +-----------------------------+");
         Console.WriteLine("      | Imprimir numeros de 1 a 100 |");
         Console.WriteLine("      +-----------------------------+\n");
         
         for (i = 1; i <= 100; i++)
          {
             if (i%10 == 0) 
                {Console.WriteLine(i);}
                  else  
                   {Console.Write(i.ToString(Masc));Console.Write(" - ");}
            
          }
            
        }
    }
}
