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
                Console.WriteLine("Contact list is full!!!");
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


    }
}
