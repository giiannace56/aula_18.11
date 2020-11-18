using System;

namespace att2
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "";
            string pass = "";

            while(true){
                Console.WriteLine("type your email:");
                    email= Console.ReadLine();

                Console.WriteLine("type your pass :");
                pass = Console.ReadLine();

                if(email == pass){
                    Console.WriteLine("you cannot use the same word for email and  password !!!");
                }else{break;}
            }
            Console.WriteLine("Thats okay , welcome " + email);
        }
    }
}