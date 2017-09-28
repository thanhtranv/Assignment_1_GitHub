using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface ICommentBusinessService
    {
        IList<CommentDto> GetAllComments();
        IList<CommentDto> SearchCommentByName(string userName, int pageIndex, int pageSize, out int total);
        CommentDto InsertComment(CommentDto commentDto);
        void UpdateComment(CommentDto commentDto);
        void DeleteComment(CommentDto commentDto);
        CommentDto GetCommentById(Guid Id);
    }
}
