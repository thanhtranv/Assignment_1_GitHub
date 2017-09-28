using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business
{
    public class BlogBusinessService : BaseBusinessService, IBlogBusinessService
    {
        private IRepository<BlogEntity> blogRepository;

        public BlogBusinessService(IRepository<BlogEntity> repo)
        {
            blogRepository = repo;
        }

        public void DeleteBlog(BlogDto blogDto)
        {
            var blog = Mapper.Map<BlogEntity>(blogDto);

            blogRepository.Delete(blog);
            blogRepository.SaveChanges();
        }

        public IList<BlogDto> GetAllBlogs()
        {
            var blog = blogRepository.GetAll();
            var blogDtos = (IList<BlogDto>)Mapper.Map(blog, blog.GetType(), typeof(IList<BlogDto>));
            return blogDtos;
        }

        public BlogDto GetBlogById(Guid Id)
        {
            var blog = blogRepository.GetById(Id);
            return Mapper.Map<BlogEntity, BlogDto>(blog);
        }

        public BlogDto InsertBlog(BlogDto blogDto)
        {
            var blog = Mapper.Map<BlogEntity>(blogDto);
            blog = blogRepository.Insert(blog);
            blogRepository.SaveChanges();

            return Mapper.Map<BlogEntity, BlogDto>(blog);
        }

        public IList<BlogDto> SearchBlogByName(string blogName, int pageIndex, int pageSize, out int total)
        {
            var blog = blogRepository.Search(p => p.Title.Contains(blogName), o => o.Title, pageIndex, pageSize, out total);
            var blogDtos = (IList<BlogDto>)Mapper.Map(blog, blog.GetType(), typeof(IList<BlogDto>));

            return blogDtos;
        }

        public void UpdateBlog(BlogDto blogDto)
        {
            var blog = Mapper.Map<BlogEntity>(blogDto);

            blogRepository.Update(blog);
            blogRepository.SaveChanges();
        }
    }

}
