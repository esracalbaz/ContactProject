using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryContactDal : IContactDal
    {
        List<Contact> _contacts;
        public InMemoryContactDal()
        {
            _contacts = new List<Contact> {
                new Contact{ContactId=1,ContactName="Esra",ContactSurname="Calbaz",Information="Me",Number="5464171716"},
                new Contact{ContactId=2,ContactName="Buket",ContactSurname="Topal",Information="Buki",Number="5071176239"},
                new Contact{ContactId=3,ContactName="Ezgi",ContactSurname="Çiftçil",Information="Ev",Number="5392080526"},
                new Contact{ContactId=4,ContactName="Ayşenur",ContactSurname="Yazar",Information="Fabs",Number="5319755315"},
                new Contact{ContactId=5,ContactName="Serdem",ContactSurname="İrdem",Information="Serdo",Number="5382636085"},
                new Contact{ContactId=6,ContactName="Meltem",ContactSurname="Özkan",Information="Melto",Number="5319747239"},
                new Contact{ContactId=7,ContactName="Samin",ContactSurname="Rahbar",Information="Saminto",Number="5384867659"},
            };
        }
        public void Add(Contact contact)
        {
            _contacts.Add(contact);
        }

        public void Delete(Contact contact)
        {
            //foreachle dongu yazmak yerine LINQ kullanmalıyım--LINQ:Language Integrated Query
            //lambda
            Contact contactToDelete = _contacts.SingleOrDefault(c=>c.ContactId== contact.ContactId);  //p: tek tek dolasirken verdigim takam isim
            _contacts.Remove(contactToDelete);
        }

        public Contact Get(Expression<Func<Contact, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Contact> GetAll()  //veritabanindaki datayi businessa vermek icin
        {
            return _contacts;
        }

        public List<Contact> GetAll(Expression<Func<Contact, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<ContactDetailDto> GetContactDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Contact contact)
        {
            //gonderdigim urun idsine sahip olan listedeki urunu bul
            Contact contactToUpdate = _contacts.SingleOrDefault(c => c.ContactId == contact.ContactId);
            contactToUpdate.ContactName = contact.ContactName;
            contactToUpdate.ContactSurname = contact.ContactSurname;
            contactToUpdate.Information = contact.Information;
            contactToUpdate.Number = contact.Number;
        }
    }
}
