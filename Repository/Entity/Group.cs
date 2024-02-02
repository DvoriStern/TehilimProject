using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Entity
{

    public class Group
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public bool IsActive { get; set; }//פעילה=1  לא פעילה=0
        public virtual ICollection<User> Users { get; set; }


    }
}
