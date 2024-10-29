using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int UserID { get; set; }

        [Index(IsUnique = true)]
        [StringLength(255)]
        public string Username { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Password { get; set; }

        public int RoleID { get; set; }

        // Navigation property
        public Role Role { get; set; }
        public ICollection<Sale> Sales { get; internal set; }
    }
}
