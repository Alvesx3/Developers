using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Developer : BaseModel
    {
        //esta classe é uma composição das demais <------

        public Profile profile { get; set; }
        public User user { get; set; }
        public Contacts contact { get; set; }
    }
}
