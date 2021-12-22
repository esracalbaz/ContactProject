using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules.FluentValidation
{
    public class ContactValidator:AbstractValidator<Contact>
    {
        public ContactValidator()
        {
            //RuleFor(c => c.ContactName).NotEmpty();
            //RuleFor(c => c.ContactName).MinimumLength(2);
            //RuleFor(c => c.ContactName).Must(StartWithA).WithMessage("Kişi ismi A harfi ile başlamalıdır");
        }

        //private bool StartWithA(string arg)
        //{
        //    return arg.StartsWith("A");
        //}
    }
}
