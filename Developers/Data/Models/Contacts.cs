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
        public string Telephone { get; set; }
        public string Linkedin { get; set; }
        //public Address Address { get; set; }
    }
}
