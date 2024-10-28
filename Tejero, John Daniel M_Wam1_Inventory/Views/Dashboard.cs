using System;
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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.Show();
            this.Close();
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.Show();
            this.Close();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Entry entry = new Entry();
            entry.Show();
            this.Close();
        }

        //public void logoutBtn_Click(object sender, EventArgs e)
        //{
        //    Entry entry = new Entry();
        //    entry.Show();
        //    this.Close();
        //}
    }
}
