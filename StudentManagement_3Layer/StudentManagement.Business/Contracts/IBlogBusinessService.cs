using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface IBlogBusinessService
    {
        IList<BlogDto> GetAllBlogs();
        IList<BlogDto> SearchBlogByName(string blogName, int pageIndex, int pageSize, out int total);
        BlogDto InsertBlog(BlogDto blogDto);
        void UpdateBlog(BlogDto blogDto);
        void DeleteBlog(BlogDto blogDto);
        BlogDto GetBlogById(Guid Id);
    }
}
