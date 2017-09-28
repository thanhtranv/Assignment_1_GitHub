using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace StudentManagement.Web.Models
{
    public class BlogPostViewModels
    {
        public Guid ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PostDate { get; set; }
    }

    public class ListPostViewModels
    {
        public List<BlogDto> BlogDto { get; set; }
    }
}