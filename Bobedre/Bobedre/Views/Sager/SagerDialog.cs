using BoBedre.Core.DataAccess;
using BoBedre.Core.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views.Sager
{
    public partial class SagerDialog : Form
    {
        private Type type { get; set; }
        private string altName { get; set; }

        public SagerDialog(Type type, string altName = null)
        {
            InitializeComponent();

            this.type = type;
            this.altName = altName;
        }

        private async void SagerDialog_Load(object sender, EventArgs e)
        {
            if (type == typeof(Kunde) && altName == "Sælger")
            {
                label1.Text = "Vælg sælger";
                var sælgere = await Fetch.GetSælgerAll();
                comboBox1.DataSource = sælgere.ToDictionary(item => item.Navn, item => item.KundeNr).ToList();
            }
            else if (type == typeof(Kunde) && altName == "Køber")
            {
                label1.Text = "Vlæg køber";
                var købere = await Fetch.GetKøberAll();
                comboBox1.DataSource = købere.ToDictionary(item => item.Navn, item => item.KundeNr).ToList();
            }
            else if (type == typeof(Ejendomsmægler))
            {
                label1.Text = "Vælg ejendomsmægler";
                var ejendomsmæglere = await Fetch.GetEjendomsmæglerAll();
                comboBox1.DataSource = ejendomsmæglere.ToDictionary(item => item.Navn, item => item.MedarbejderNr).ToList();
            }
            else if (type == typeof(Ejendom))
            {
                label1.Text = "Vælg ejendom";
                var ejendom = await Fetch.GetEjendomAll();
                comboBox1.DataSource = ejendom.ToDictionary(item => $"BoligNr: {item.BoligNr}, Addresse: {item.Adresse}, Postnummer: {item.PostNr}", item => item.BoligNr).ToList();
            }

            comboBox1.ValueMember = "Key";
            comboBox1.SelectedText = "Value";
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
