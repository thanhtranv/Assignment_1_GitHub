using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class CategoryEntity : BaseEntity
    {
        
        public string Name { get; set; }

        public virtual ICollection<BlogEntity> Blogs { get; set; }
     
    }
}
