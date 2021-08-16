using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Profile : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Birthday { get; set; }
    }
}
