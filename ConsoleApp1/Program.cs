using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        Inicio:
            Double Num1, Num2;
            Console.Write("Digite um valor: ");
            Num1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Digite um valor: ");
            Num2 = Convert.ToDouble(Console.ReadLine());
              if (Num1 != Num2) 
             {
                if (Num1 < Num2)
                {
                    Console.WriteLine("Os números em ordem crescente são: " + Num1 + " e " + Num2);
                }
                else 
                {
                    Console.WriteLine("Os números em ordem crescente são: " + Num2 + " e " + Num1);
                }
               
            } 
            else
            {
                Console.Clear();
                Console.WriteLine("Os números são iguais, digite novamente");
                
                goto Inicio;
               
            }
            
            Console.ReadKey();
       }
        
    }
}
