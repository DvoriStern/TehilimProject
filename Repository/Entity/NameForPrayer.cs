using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{
    public class NameForPrayer
    {
        public int Id { get; set; }
        public string NameForPray { get; set; } = "";
        public string ? PersonalRequest { get; set; }//בקשה אישית במקרה שבחר אחר בבקשה

        public virtual RequestPrayer RequestPrayer { get; set; }


    }
}
