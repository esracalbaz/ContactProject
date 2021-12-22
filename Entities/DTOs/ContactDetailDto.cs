using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ContactDetailDto:IDto
    {
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public string ContactSurname { get; set; }
        public string Information { get; set; }
        public long Number { get; set; }
    }
}
