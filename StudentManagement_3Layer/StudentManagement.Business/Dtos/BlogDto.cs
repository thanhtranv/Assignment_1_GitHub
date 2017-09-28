using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Dtos
{
    public class BlogDto : BaseDto
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
        public Guid IDCategory { get; set; }
        public Guid IDUser { get; set; }

        public UserDto User { get; set; }
        public CategoryDto Category { get; set; }
        public virtual ICollection<CommentDto> Comments { get; set; }
        public virtual ICollection<ImageDto> Images { get; set; }
    }
}
