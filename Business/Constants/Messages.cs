using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages  //static--newlememek için(sabit)
    {
        public static string ContactAdded = "Kişi eklendi";       //publicler pascal case yazılır
        public static string ContactNameInvalid = "Kişi ismi geçersiz";
        public static string MaintenanceTime="Sistem bakımda";
        public static string ContactsListed="Kişiler listelendi";
        public static string ContactDeleted = "Kişi silindi";
        public static string ContactUpdated = "Kişi güncellendi";
    }
}
