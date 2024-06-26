using System;
using PhooneBook.Models;

namespace PhooneBook.Service
{
    public class PhoneBookService
    {
        private PhoneBook[] phoneBooks = new PhoneBook[50];
        private int phoneBookCount = 0;

        public void AddPhoneBook(string firstName, string lastName, string phoneNumber)
        {
            if (phoneBookCount > phoneBooks.Length)
            {
                phoneBooks[phoneBookCount] = new PhoneBook
                {
                    Id = phoneBookCount + 1,
                    FirstName = firstName,
                    LastName = lastName,
                    PhoneNumber = phoneNumber
                };

                phoneBookCount++;
            }
            else
            {
                Console.WriteLine("Phonebook list is full!!!");
            }
        }

        public void RemoveContactAtPhonebook(int id)
        {
            bool found = false;
            for (int i = 0; i < phoneBookCount; i++)
            {
                if (phoneBooks[i].Id == id)
                {
                    for (int j = i; j < phoneBookCount - 1; j++)
                    {
                        phoneBooks[j] = phoneBooks[j + 1];
                    }
                    phoneBooks[phoneBookCount - 1] = null;
                    phoneBookCount--;
                    found = true;
                    break;
                }
            }
            if (!found)
            {
                Console.WriteLine("Phone book not found.");
            }
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

        public bool IsValidInteger(string input, out int result)
        {
            try
            {
                result = int.Parse(input);
                return true;
            }
            catch
            {
                result = 0;
                return false;
            }
        }
    }
}