﻿using DevComponents.DotNetBar;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LowerApplication.Forms
{
    public partial class frmMaster : Office2007RibbonForm
    {

        protected bool mbolNew = true;
        protected int returnValue = -1;


        public frmMaster()
        {
            InitializeComponent();
        }

        private void frmMaster_Load(object sender, EventArgs e)
        {

        }
    }
}
