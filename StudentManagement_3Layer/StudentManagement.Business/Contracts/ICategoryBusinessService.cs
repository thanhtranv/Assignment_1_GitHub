using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface ICategoryBusinessService
    {
        IList<CategoryDto> GetAllCategories();
        IList<CategoryDto> SearchCategoryByName(string categoryName, int pageIndex, int pageSize, out int total);
        CategoryDto InsertCategory(CategoryDto categoryDto);
        void UpdateCategory(CategoryDto categoryDto);
        void DeleteCategory(CategoryDto categoryDto);
        CategoryDto GetCategoryById(Guid Id);
    }
}
