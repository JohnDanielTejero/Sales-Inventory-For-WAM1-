using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO
{
    public class Sale
    {
        public int SaleID { get; set; }
        public int UserID { get; set; }
        public DateTime Date_Creation { get; set; }
        public string CustomerName { get; set; }

        public User User { get; set; }
        public ICollection<SalesItem> SalesItems { get; set; }
    }
}
