using BoBedre.Core.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bobedre.Views
{
    public partial class Baseform : Form
    {
        private Form activeForm;

        public Baseform()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Shows a form in the content panel
        /// </summary>
        /// <param name="newForm"></param>
        public void ShowForm(Form newForm)
        {
            // If a form is open then close it before opening a new one
            if (activeForm != null)
            {
                activeForm.Close();
            }

            // Set the content to the new form
            activeForm = newForm;
            newForm.TopLevel = false;
            newForm.FormBorderStyle = FormBorderStyle.None;
            newForm.Dock = DockStyle.Fill;
            content.Controls.Add(newForm);
            content.Tag = newForm;
            newForm.BringToFront();
            newForm.Show();
        }

        #region Menu buttons
        /// <summary>
        /// Controls if menu buttons are showing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void menuButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Fremvisning.Fremvisning());
        }

        private void kunderButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Kunder.KunderView(this));
        }

        private void ejendommeButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Ejendomme.EjendommeView(this));
        }

        private void ejendomsmæglereButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Ejendomsmæglere.EjendomsmæglereView(this));
            
        }

        private void sagerButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Sager.SagerView(this));
        }

        private void statistikButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Statistik.Statistik());
        }

        private void åbenhusButton_Click(object sender, EventArgs e)
        {
            ShowForm(new ÅbentHus.ÅbentHus(Models.Action.view, this));
        }
        
        private void AnnonceringerButton_Click(object sender, EventArgs e)
        {
            ShowForm(new Annoncering.AnnonceringView(this));
        }
        #endregion

        private void Baseform_Load(object sender, EventArgs e)
        {
            ShowForm(new Fremvisning.Fremvisning());
        }
    }
}
