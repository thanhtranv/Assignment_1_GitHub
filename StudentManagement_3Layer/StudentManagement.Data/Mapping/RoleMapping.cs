using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Mapping
{
    public class RoleMapping : EntityTypeConfiguration<RoleEntity>
    {
        public RoleMapping()
        {
            ToTable("Role").HasKey(k => k.ID);
        }
    }
}
