﻿using System;

namespace fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um numero :");
            int num;
                int x=1, y=0, z=0;
                    num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; i++){
            z = x + y;
            Console.WriteLine(z);
            y = x;
            x = z;
                }
                Console.ReadLine();
        }
    }
}
