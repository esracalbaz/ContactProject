using Business.Abstract;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcerns.Validation;
using Core.Utilities.Business;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;  //injection

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        [ValidationAspect(typeof(ContactValidator))]
        public IResult Add(Contact contact)
        {
            //business codes
            //BusinessRules.Run();
            _contactDal.Add(contact);
            return new SuccessResult(Messages.ContactAdded);
        }

        public IResult Delete(Contact contact)
        {
            _contactDal.Delete(contact);
            return new SuccessResult(Messages.ContactDeleted);
        }

        public IDataResult<List<Contact>> GetAll()
        {
            if (DateTime.Now.Hour == 22)
            {
                return new ErrorDataResult<List<Contact>>(Messages.MaintenanceTime);
            }
            return new SuccessDataResult<List<Contact>>(_contactDal.GetAll(),Messages.ContactsListed);
        }

        public IDataResult<Contact> GetById(int contactId)
        {
            return new SuccessDataResult<Contact>(_contactDal.Get(c=>c.ContactId==contactId));
        }

        [ValidationAspect(typeof(ContactValidator))]
        public IResult Update(Contact contact)
        {
            _contactDal.Update(contact);
            return new SuccessResult(Messages.ContactUpdated);
        }

        /*public IDataResult<List<ContactDetailDto>> GetContactDetails()
        {
            return new SuccessDataResult<List<ContactDetailDto>>(_contactDal.GetContactDetails());
        } */
    }
}
