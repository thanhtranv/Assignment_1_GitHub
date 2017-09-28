using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class RoleDto : BaseDto
    {
        public string RoleName { get; set; }

        public virtual ICollection<UserDto> Users { get; set; }
    }
}
