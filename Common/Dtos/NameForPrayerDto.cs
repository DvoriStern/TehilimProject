using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Dtos
{
    public class NameForPrayerDto
    {
        public int Id { get; set; }
        public string NameForPray { get; set; } = "";
        public string? PersonalRequest { get; set; }//בקשה אישית במקרה שבחר אחר בבקשה

        public virtual RequestPrayer RequestPrayer { get; set; }//??

    }
}
