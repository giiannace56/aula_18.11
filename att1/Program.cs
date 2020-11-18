using System;

namespace att1
{
    class Program
    {
        static void Main(string[] args)
        {
            int nota ;
            do {
            Console.Write("digite um numero entre 0 - 10 : ");
                 nota = int.Parse(Console.ReadLine());

                if(nota <0 || nota >10){
                    Console.WriteLine("algarismo inválido");
                }
        } 
        
            while(nota <0 || nota >10);

            Console.WriteLine("algorismo valido!!");
        }
    }
}


