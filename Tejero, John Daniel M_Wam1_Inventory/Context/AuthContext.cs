using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO;
using Tejero__John_Daniel_M_Wam1_Inventory.Views;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Context
{
    public class AuthContext
    {
        private static AuthContext _instance = null;
        private static readonly object _lock = new object();
        private static User user;

        public static AuthContext Instance()
        {
            lock (_lock)
            {
                if (_instance == null)
                    _instance = new AuthContext();
                return _instance;
            }
        }

        public static void login(User u)
        {
            user = u;
        }

        public static void logout(Form f) {
            f.Close();
            Entry e = new Entry();
            e.Show();
            user = null;
        }

        public static User getUser() {
            return user;
        }

        //need more efficient way of automating navigation
        public static void navigateTo(Form f, string path)
        {
            if (path.Equals("Dashboard"))
            {

                f.Hide();
                Dashboard view = new Dashboard();
                view.Show();
            }else if (path.Equals("Sales"))
            {
                f.Hide();
                SalesForm view = new SalesForm();
                view.Show();
            }
            else if (path.Equals("Users"))
            {
                f.Hide();
                UsersForm view = new UsersForm();
                view.Show();
            }
            else if (path.Equals("Categories"))
            {
                f.Hide();
                CategoriesForm view = new CategoriesForm();
                view.Show();
            }
            else if (path.Equals("Products"))
            {
                f.Hide();
                ProductsForm view = new ProductsForm();
                view.Show();
            }

        }
    }
}
