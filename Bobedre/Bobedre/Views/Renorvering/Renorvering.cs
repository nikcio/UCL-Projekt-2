using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Renorvering
{
    public partial class Renorvering : Form
    {
        public Baseform baseform { get; set; }

        public Renorvering(Models.Action action, Baseform _baseform)
        {
            InitializeComponent();

            baseform = _baseform;

            switch (action)
            {
                case Models.Action.create:
                    SletButton.Visible = false;
                    GemButton.Visible = false;
                    break;

                case Models.Action.delete:
                    OpretButton.Visible = false;
                    GemButton.Visible = false;
                    break;

                case Models.Action.edit:
                    SletButton.Visible = false;
                    OpretButton.Visible = false;
                    break;

                case Models.Action.view:
                    SletButton.Visible = false;
                    OpretButton.Visible = false;
                    GemButton.Visible = false;
                    break;
            }
        }

    }
}
