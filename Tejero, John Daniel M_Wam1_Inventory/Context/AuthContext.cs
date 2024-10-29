using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.Context;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;
using Tejero__John_Daniel_M_Wam1_Inventory.Views;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Context
{
    public class AuthContext
    {
        private User user;
       
        public void login(User u)
        {
            this.user = u;
        }
        public void logout(Form f) {
            this.user = null;
            Entry entry = new Entry();
            entry.Show();
            f.Close();
        }

        public User getUser() {
            return this.user;
        }
    }
}
