using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;

namespace StudentManagement.Business
{
    public class CommentBusinessService : BaseBusinessService, ICommentBusinessService
    {
        private IRepository<CommentEntity> commentRepository;

        public CommentBusinessService(IRepository<CommentEntity> repo)
        {
            commentRepository = repo;
        }

        public void DeleteComment(CommentDto commentDto)
        {
            var comment = Mapper.Map<CommentEntity>(commentDto);

            commentRepository.Delete(comment);
            commentRepository.SaveChanges();
        }

        public IList<CommentDto> GetAllComments()
        {
            var comment = commentRepository.GetAll();
            var commentDtos = (IList<CommentDto>)Mapper.Map(comment, comment.GetType(), typeof(IList<CommentDto>));
            return commentDtos;
        }

        public CommentDto GetCommentById(Guid Id)
        {
            var comment = commentRepository.GetById(Id);
            return Mapper.Map<CommentEntity, CommentDto>(comment);
        }

        public CommentDto InsertComment(CommentDto commentDto)
        {
            var comment = Mapper.Map<CommentEntity>(commentDto);
            comment = commentRepository.Insert(comment);
            commentRepository.SaveChanges();

            return Mapper.Map<CommentEntity, CommentDto>(comment);
        }

        public IList<CommentDto> SearchCommentByName(string userName, int pageIndex, int pageSize, out int total)
        {
            var comment = commentRepository.Search(p => p.User.Username.Contains(userName), o => o.User.Username, pageIndex, pageSize, out total);
            var commentDtos = (IList<CommentDto>)Mapper.Map(comment, comment.GetType(), typeof(IList<CommentDto>));

            return commentDtos;
        }

        public void UpdateComment(CommentDto commentDto)
        {
            var comment = Mapper.Map<CommentEntity>(commentDto);

            commentRepository.Update(comment);
            commentRepository.SaveChanges();
        }
    }
}
