using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        //SOLID
        //Open closed principle
        static void Main(string[] args)
        {
            ContactTest();
        }
        private static void ContactTest()
        {
            ContactManager contactManager = new ContactManager(new EfContactDal());
            var result = contactManager.GetAll();  //.GetContactDetails()
            if (result.Success==true)
            {
                foreach (var contact in result.Data)  
                {
                    Console.WriteLine(contact.ContactName);
                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
