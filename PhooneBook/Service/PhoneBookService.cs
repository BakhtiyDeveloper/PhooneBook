using System;
using PhooneBook.Models;

namespace PhooneBook.Service
{
    public class PhoneBookService
    {
        private PhoneBook[] phoneBooks = new PhoneBook[50];
        private int phoneBookCount = 0;
        
        public void AddPhoneBook (string firstName,  string lastName, string phoneNumber) 
        {
            if (phoneBookCount >= phoneBooks.Length)
            {
                Console.WriteLine("Phonebook list is full!!!");
                return;
            }

            phoneBooks[phoneBookCount] = new PhoneBook
            {
                Id = phoneBookCount,
                FirstName = firstName,
                LastName = lastName,
                PhoneNumber = phoneNumber
            };
            
            phoneBookCount++;
        }

        public void RemoveContactAtPhonebook(int id) 
        {
            if (id < 0 || id >= phoneBookCount)
            {
                Console.WriteLine("You have entered an incorrect id");
                return;
            }

            for (int i = id; i < phoneBookCount - 1; i++)
            {
                phoneBooks[i] = phoneBooks[i + 1];
            }

            phoneBooks[phoneBookCount - 1] = null;
            phoneBookCount--;
        }

        public void ShowAllPhoneBooks() 
        {
            Console.WriteLine("Phonebooks:");
            for (int i = 0; i < phoneBookCount; i++)
            {
                var phoneBook = phoneBooks[i];
                Console.WriteLine($"ID: {phoneBook.Id}, Name: {phoneBook.FirstName} {phoneBook.LastName}, Phone: {phoneBook.PhoneNumber}");
            }
        }
    }
}
