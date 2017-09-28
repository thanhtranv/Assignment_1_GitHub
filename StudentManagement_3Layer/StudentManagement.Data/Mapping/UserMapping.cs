using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Mapping
{
    public class UserMapping : EntityTypeConfiguration<UserEntity>
    {
        public UserMapping()
        {
            ToTable("User").HasKey(k => k.ID);
        }
    }
}
