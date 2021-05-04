using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Models
{
    public abstract class DataForm: Form
    {
        public abstract void LoadData(int id);
    }
}
