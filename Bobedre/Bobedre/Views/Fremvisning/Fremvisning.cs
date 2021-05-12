using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Fremvisning
{
    public partial class Fremvisning : Form
    {
        private delegate void LoadDataDelegate(Ejendomsmægler ejendomsmægler);

        public Fremvisning()
        {
            InitializeComponent();
        }

        private void LoadData(Ejendomsmægler ejendomsmægler)
        {
            MedarbejderNavn.Text = ejendomsmægler.Navn;
            MedarbjderNr.Text = ejendomsmægler.MedarbejderNr.ToString();
            Afdeling.Text = ejendomsmægler.Afdeling;
            MæglerFirma.Text = ejendomsmægler.Mæglerfirma;
            Email.Text = ejendomsmægler.Email;
            MedarbejderNavn.Visible = true;
            MedarbjderNr.Visible = true;
            Afdeling.Visible = true;
            MæglerFirma.Visible = true;
            Email.Visible = true;
        }

        private async Task Dias()
        {
            var ejendomsmæglers = await Fetch.GetEjendomsmæglerAll();
            int i = 0;
            var d = new LoadDataDelegate(LoadData);
            while (true)
            {
                if(i >= ejendomsmæglers.Length)
                {
                    i = 0;
                }
                Invoke(d, new object[] { ejendomsmæglers[i] });
                i++;
                await Task.Delay(60000);
            }
        }

        private void Fremvisning_Load(object sender, EventArgs e)
        {
            Task.Run(() => Dias());
        }
    }
}
