using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using BoBedre.Core.DataAccess;
using Bobedre.Utility;

namespace Bobedre.Views.Kunder
{
    public partial class Kunder : Form
    {
        private readonly string BasicTextRegex = @"^[a-z A-ZåæøÅÆØ]+$";
        private readonly string EmailRegex = "^(?(\")(\".+?(?<!\\)\"@)|(([0 - 9a - z]((\\.(?!\\.))|[-!#\\$%&'\\*\\+/=\\?\\^`\\{\\}\\|~\\w])*)(?<=[0-9a-z])@))(?(\\[)(\\[(\\d{1,3}\\.){3}\\d{1,3}\\])|(([0-9a-z][-\\w]*[0-9a-z]*\\.)+[a-z0-9][\\-a-z0-9]{0,22}[a-z0-9]))$"; // Taken from: https://emailregex.com/

        public Kunder(Models.Action action, Baseform baseform)
        {
            InitializeComponent();
        }

        private async void KundeOpretKnap_Click(object sender, EventArgs e)
        {
            if ((TextCheck(KundeNavnBox.Text)) && EmailCheck(KundeEmailBox.Text))
            {
                var message = await NonQuery.CreateKunde(KundeNavnBox.Text, KundeEmailBox.Text);
                ClearForm.CleanForm(Controls);

                MessageBox.Show(message);
            }
            else
            {
                MessageBox.Show("Kunden er ikke blevet oprettet pga. brug af forkerte tegn");
            }
        }

        private bool TextCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, BasicTextRegex);
        }

        private bool EmailCheck(string textToCheck)
        {
            return Regex.IsMatch(textToCheck, EmailRegex);
        }


    }

}
