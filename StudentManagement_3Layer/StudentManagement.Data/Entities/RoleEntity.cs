using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class RoleEntity : BaseEntity
    {
        
        public string RoleName { get; set; }
       
        public virtual ICollection<UserEntity> Users { get; set; }
    }
}
