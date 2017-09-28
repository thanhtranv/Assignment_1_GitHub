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
    public class UserBusinessService : BaseBusinessService, IUserBusinessService
    {
        private IRepository<UserEntity> userRepository;

        public UserBusinessService(IRepository<UserEntity> repo)
        {
            userRepository = repo;
        }

        public void DeleteUser(UserDto userDto)
        {
            var user = Mapper.Map<UserEntity>(userDto);

            userRepository.Delete(user);
            userRepository.SaveChanges();
        }

        public IList<UserDto> GetAllUsers()
        {
            var user = userRepository.GetAll();
            var userDtos = (IList<UserDto>)Mapper.Map(user, user.GetType(), typeof(IList<UserDto>));
            return userDtos;
        }

        public UserDto GetUserById(Guid Id)
        {
            var user = userRepository.GetById(Id);
            return Mapper.Map<UserEntity, UserDto>(user);
        }

        public UserDto InsertUser(UserDto userDto)
        {
            var user = Mapper.Map<UserEntity>(userDto);
            user = userRepository.Insert(user);
            userRepository.SaveChanges();

            return Mapper.Map<UserEntity, UserDto>(user);
        }

        public IList<UserDto> SearchUserByName(string userName, int pageIndex, int pageSize, out int total)
        {
            var user = userRepository.Search(p => p.Username.Contains(userName), o => o.Username, pageIndex, pageSize, out total);
            var userDtos = (IList<UserDto>)Mapper.Map(user, user.GetType(), typeof(IList<UserDto>));

            return userDtos;
        }

        public void UpdateUser(UserDto userDto)
        {
            var user = Mapper.Map<UserEntity>(userDto);

            userRepository.Update(user);
            userRepository.SaveChanges();
        }
    }

}
