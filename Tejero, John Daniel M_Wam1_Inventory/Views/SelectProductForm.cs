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
    public partial class SelectProductForm : Form
    {
        private Action<object> parentFormAction;
        public SelectProductForm(Action<object> parentFormAction)
        {
            InitializeComponent();
            this.parentFormAction = parentFormAction;
        }
    }
}
