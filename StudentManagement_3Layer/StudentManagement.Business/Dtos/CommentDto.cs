using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class CommentDto : BaseDto
    {
        public string Content { get; set; }
        public DateTime CommentDate { get; set; }
        public Guid IDUser { get; set; }
        public Guid IDBlog { get; set; }

        public virtual UserDto User { get; set; }
        public virtual BlogDto Blog { get; set; }
    }
}
