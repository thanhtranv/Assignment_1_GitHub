using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class BlogEntity : BaseEntity
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public Guid IDCategory { get; set; }
        public Guid IDUser { get; set; }

        public UserEntity User { get; set; }
        public CategoryEntity Category { get; set; }
        public virtual ICollection<CommentEntity> Comments { get; set; }
        public virtual ICollection<ImageEntity> Images { get; set; }
    }
}
