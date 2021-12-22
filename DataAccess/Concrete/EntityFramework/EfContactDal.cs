using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    //NuGet
    public class EfContactDal : EfEntityRepositoryBase<Contact,ContactContext>, IContactDal
    {
        /*public List<ContactDetailDto> GetContactDetails()
        {
                            9-2:47
        } */
    }
}
