using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Contacts : BaseModel
    {
        public string Email { get; set; }
        public Int64 Telephone { get; set; }
        public string Linkedin { get; set; }
    }
}
