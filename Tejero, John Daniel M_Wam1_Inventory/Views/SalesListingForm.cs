﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Views
{
    public partial class SalesListingForm : Form
    {
        private Action<object> parentFormAction;
        public SalesListingForm(Action<object> loadform)
        {
            InitializeComponent();
            this.parentFormAction = loadform;
        }

        private void addSalesButton_Click(object sender, EventArgs e)
        {
            this.parentFormAction(new AddSalesForm(this.parentFormAction));
        }
    }
}
