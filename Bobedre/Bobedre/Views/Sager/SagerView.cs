﻿using System;
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
    public partial class SagerView : Form
    {
        public Baseform baseform { get; set; }
        public SagerView(Baseform _baseform)
        {
            InitializeComponent();

            baseform = _baseform;
        }

        private void OpretSagButton_Click(object sender, EventArgs e)
        {

        }
    }
}
