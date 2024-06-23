using System;
using PhooneBook.Models;


internal class Program
{
    public static void Main(string[] args)
    {
        string yesOrNo = "";
        do
        {

            







            Console.WriteLine("Dasturdan yana foydalanish!!! yes / no");
            yesOrNo = Console.ReadLine();
            yesOrNo.ToLower();
        } while (yesOrNo == "yes" | yesOrNo == "y");

        Console.WriteLine("dastur tugadi");



    }
}