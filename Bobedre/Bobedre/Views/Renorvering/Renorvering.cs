using Bobedre.Models;
using BoBedre.Core.DataAccess;
using BoBedre.Core.TextChecking;
using System;
using System.Windows.Forms;

namespace Bobedre.Views.Renorvering
{
    public partial class Renorvering : Form
    {
        private Baseform baseform { get; set; }
        private Form prevForm { get; set; }
        private int boligNr { get; set; }
        public Models.Action action { get; set; }
        public int renorveringsId { get; set; }

        public Renorvering(Models.Action _action, Baseform _baseform, Form _prevForm, int _renorveringsId = -1, int _boligNr = -1)
        {
            InitializeComponent();

            baseform = _baseform;
            prevForm = _prevForm;
            boligNr = _boligNr;
            action = _action;
            renorveringsId = _renorveringsId;
        }

        private async void LoadData(int id)
        {
            if(id < 0)
            {
                throw new ArgumentOutOfRangeException("id", "id can not be under 0");
            }

            var renorvering = await Fetch.GetRenorveringByRenorveringsId(id);

            RenorveringsIdTextbox.Text = renorvering.RenorveringsId.ToString();
            OmbygningsårTextbox.Text = renorvering.Ombygningsår.ToString();
            DetalijerTextbox.Text = renorvering.Detaljer;
            KøkkenCheckbox.Checked = renorvering.Køkken;
            Badeværelsecheckbox.Checked = renorvering.Badeværelse;
            Andetcheckbox.Checked = renorvering.Andet;
        }

        private async void OpretButton_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TalCheck(OmbygningsårTextbox.Text))
            {
                await EntryManagement.CreateRenorvering(KøkkenCheckbox.Checked, Badeværelsecheckbox.Checked, Andetcheckbox.Checked, int.Parse(OmbygningsårTextbox.Text), DetalijerTextbox.Text, boligNr);
                baseform.ShowForm(prevForm);
            }
        }

        private async void GemButton_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TalCheck(OmbygningsårTextbox.Text) && RegexCheck.TalCheck(RenorveringsIdTextbox.Text))
            {
                await EntryManagement.UpdateRenorvering(KøkkenCheckbox.Checked, Badeværelsecheckbox.Checked, Andetcheckbox.Checked, int.Parse(OmbygningsårTextbox.Text), DetalijerTextbox.Text, int.Parse(RenorveringsIdTextbox.Text));
                baseform.ShowForm(prevForm);
            }
        }

        private async void SletButton_Click(object sender, EventArgs e)
        {
            if (RegexCheck.TalCheck(RenorveringsIdTextbox.Text))
            {
                await EntryManagement.DeleteRenorvering(int.Parse(RenorveringsIdTextbox.Text));
                baseform.ShowForm(prevForm);
            }
        }

        private void LukButton_Click(object sender, EventArgs e)
        {
            baseform.ShowForm(prevForm);
        }

        private void Renorvering_Load(object sender, EventArgs e)
        {
            switch (action)
            {
                case Models.Action.create:
                    SletButton.Visible = false;
                    GemButton.Visible = false;
                    break;

                case Models.Action.delete:
                    OpretButton.Visible = false;
                    GemButton.Visible = false;
                    LoadData(renorveringsId);
                    break;

                case Models.Action.edit:
                    SletButton.Visible = false;
                    OpretButton.Visible = false;
                    LoadData(renorveringsId);
                    break;

                case Models.Action.view:
                    SletButton.Visible = false;
                    OpretButton.Visible = false;
                    GemButton.Visible = false;
                    LoadData(renorveringsId);
                    break;
            }
        }
    }
}
