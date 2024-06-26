using System;
using PhooneBook.Models;
using PhooneBook.Service;

namespace PhooneBook
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            PhoneBookService phoneBookService = new PhoneBookService();

            string yesOrNo = "";
            do 
            {
                Console.WriteLine("Welcome to our PhoneBook program");
                Console.WriteLine("In this program, it works in a console window, \n" +
                                   "where you can add, delete, and view information \n" +
                                   "about the people you want in the phonebook.");

                AddPhoneBook(phoneBookService);

                Console.WriteLine("Do you want to add more information? (yes / no)");
                
                string answer = Console.ReadLine();
                if (answer.ToLower() == "yes" | answer.ToLower() == "y") 
                {
                    ShowAllPhoneBooks(phoneBookService);
                }

                Console.WriteLine("Do you want continue? Yes/No or y/n");
                yesOrNo = Console.ReadLine();
            } while (yesOrNo.ToLower() == "yes" | yesOrNo.ToLower() == "y");

            Console.WriteLine("Thank you for using our program");

            static void AddPhoneBook(PhoneBookService phoneBookService)
            {
                Console.WriteLine("Enter first name: ");
                string firstName = Console.ReadLine();
                
                Console.WriteLine("Enter last name: ");
                string lastName = Console.ReadLine();
                
                Console.Write("Enter your phone number: ");
                string phoneNumber = Console.ReadLine();

                phoneBookService.AddPhoneBook(firstName, lastName, phoneNumber);
            }

            static void RemoveContactAtPhonebook(PhoneBookService phoneBookService)
            {
                int indexData = GetIndexDataFromUser();
                phoneBookService.RemoveContactAtPhonebook(indexData);
            }

            static void ShowAllPhoneBooks(PhoneBookService phoneBookService) 
            {
                phoneBookService.ShowAllPhoneBooks();
            }

            static void GetIndexDataFromUser() 
            {
                while (true)
                {
                    Console.Write("Enter the index of the contact: ");
                    inputIndexData = Console.ReadLine();

                    if (int.TryParse(inputIndexData, out int indexData))
                    {
                        return indexData;
                    }
                    else
                    {
                        Console.WriteLine("Invalid index. Please enter a valid integer.");
                    }
                }
            }
        }


    }
}