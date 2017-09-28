using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface IUserBusinessService
    {
        IList<UserDto> GetAllUsers();
        IList<UserDto> SearchUserByName(string userName, int pageIndex, int pageSize, out int total);
        UserDto InsertUser(UserDto userDto);
        void UpdateUser(UserDto userDto);
        void DeleteUser(UserDto userDto);
        UserDto GetUserById(Guid Id);
    }
}
