using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IContactDal:IEntityRepository<Contact> //contact ile ilgili veri tabanında yapacağım operasyonları içeren interface
    {
        //List<ContanctDetailDto> GetContanctDetails();
    }
}
//Code Refactoring