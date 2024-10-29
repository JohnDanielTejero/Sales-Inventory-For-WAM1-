using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tejero__John_Daniel_M_Wam1_Inventory.Database.DAO
{
    public class Role
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RoleID { get; set; }
        [Index(IsUnique = true)]
        [StringLength(255)]
        public string RoleName { get; set; }
        public string RoleDescription { get; set; }

        public ICollection<User> Users { get; set; }
    }
}
