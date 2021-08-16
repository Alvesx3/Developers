using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
	public class Addess : BaseModel
	{
		public string Country{ get; set; }
		public string City { get; set; }
		public string PostalCode { get; set; }
		public string Neighborhood{ get; set; }
		public string Street{ get; set; }
		public string Complement{ get; set; }
		public int Number { get; set; }
	}
}
