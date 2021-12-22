using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IContactService
    {
        IDataResult<List<Contact>> GetAll();  //IDataResult data içerir
        //IDataResult<List<ContactDetailDto>> GetContactDetails();
        IDataResult<Contact> GetById(int contactId);
        IResult Add(Contact contact);  //void var     ,data yok     , mesaj ve işlem sonucunu IResult içeriyor
        IResult Update(Contact contact);
        IResult Delete(Contact contact);


    }
}
