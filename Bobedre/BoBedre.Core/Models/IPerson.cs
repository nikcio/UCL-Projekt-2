using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BoBedre.Core.Models
{
    public interface IPerson
    {
        public string Navn { get; set; }
        public string Email { get; set; }
    }
}
