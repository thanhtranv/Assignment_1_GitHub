using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class UserEntity : BaseEntity
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Image { get; set;}
        public Guid IDRole { get; set; }

        public virtual RoleEntity Role { get; set; }
        public virtual ICollection<BlogEntity> Blogs { get; set; }
    }
}
