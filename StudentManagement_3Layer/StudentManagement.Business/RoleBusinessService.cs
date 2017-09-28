using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;

namespace StudentManagement.Business
{
    public class RoleBusinessService : BaseBusinessService, IRoleBusinessService
    {
        private IRepository<RoleEntity> roleRepository;

        public RoleBusinessService(IRepository<RoleEntity> repo)
        {
            roleRepository = repo;
        }

        public void DeleteRole(RoleDto roleDto)
        {
            var role = Mapper.Map<RoleEntity>(roleDto);

            roleRepository.Delete(role);
            roleRepository.SaveChanges();
        }

        public IList<RoleDto> GetAllRoles()
        {
            var role = roleRepository.GetAll();
            var roleDtos = (IList<RoleDto>)Mapper.Map(role, role.GetType(), typeof(IList<RoleDto>));
            return roleDtos;
        }

        public RoleDto GetRoleById(Guid Id)
        {
            var role = roleRepository.GetById(Id);
            return Mapper.Map<RoleEntity, RoleDto>(role);
        }

        public RoleDto InsertRole(RoleDto roleDto)
        {
            var role = Mapper.Map<RoleEntity>(roleDto);
            role = roleRepository.Insert(role);
            roleRepository.SaveChanges();

            return Mapper.Map<RoleEntity, RoleDto>(role);
        }

        public IList<RoleDto> SearchRoleByName(string roleName, int pageIndex, int pageSize, out int total)
        {
            var role = roleRepository.Search(p => p.RoleName.Contains(roleName), o => o.RoleName, pageIndex, pageSize, out total);
            var roleDtos = (IList<RoleDto>)Mapper.Map(role, role.GetType(), typeof(IList<RoleDto>));

            return roleDtos;
        }

        public void UpdateRole(RoleDto roleDto)
        {
            var role = Mapper.Map<RoleEntity>(roleDto);

            roleRepository.Update(role);
            roleRepository.SaveChanges();
        }
    }
}
