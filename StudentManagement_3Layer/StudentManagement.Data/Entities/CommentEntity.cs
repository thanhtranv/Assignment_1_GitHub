using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data.Entities
{
    public class CommentEntity : BaseEntity
    {
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public Guid IDUser { get; set; }
        public Guid IDBlog { get; set; }

        public virtual UserEntity User { get; set; }
        public virtual BlogEntity Blog { get; set; }
    }
}
