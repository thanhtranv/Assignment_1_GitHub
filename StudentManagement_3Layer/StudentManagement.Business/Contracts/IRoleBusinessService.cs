using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface IRoleBusinessService
    {
        IList<RoleDto> GetAllRoles();
        IList<RoleDto> SearchRoleByName(string roleName, int pageIndex, int pageSize, out int total);
        RoleDto InsertRole(RoleDto roleDto);
        void UpdateRole(RoleDto roleDto);
        void DeleteRole(RoleDto roleDto);
        RoleDto GetRoleById(Guid Id);
    }
}
