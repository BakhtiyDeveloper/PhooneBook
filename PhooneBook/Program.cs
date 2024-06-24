using System;
using PhooneBook.Models;
using PhooneBook.Services;

namespace PhooneBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string yesOrNo = "";
            do
            {





                Console.WriteLine("Will you use the program again??? yes / no");
                yesOrNo = Console.ReadLine();
                yesOrNo.ToLower();
            } while (yesOrNo == "yes" | yesOrNo == "y");

            Console.WriteLine("Thank you for using the program!!!");

            Console.ReadKey();

        }


    }
}