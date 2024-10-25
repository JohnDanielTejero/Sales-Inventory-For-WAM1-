using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO
{
    public class Stock
    {
        [Key, ForeignKey("Product")]
        public int ProductID { get; set; }
        public int Quantity { get; set; }
        public DateTime Last_Updated { get; set; }

        public Product Product { get; set; }
    }
}
