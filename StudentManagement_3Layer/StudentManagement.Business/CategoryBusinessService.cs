using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;

namespace StudentManagement.Business
{
    public class CategoryBusinessService : BaseBusinessService, ICategoryBusinessService
    {
        private IRepository<CategoryEntity> categoryRepository;

        public CategoryBusinessService(IRepository<CategoryEntity> repo)
        {
            categoryRepository = repo;
        }

        public void DeleteCategory(CategoryDto categoryDto)
        {
            var category = Mapper.Map<CategoryEntity>(categoryDto);

            categoryRepository.Delete(category);
            categoryRepository.SaveChanges();
        }

        public IList<CategoryDto> GetAllCategories()
        {
            var category = categoryRepository.GetAll();
            var categoryDtos = (IList<CategoryDto>)Mapper.Map(category, category.GetType(), typeof(IList<CategoryDto>));
            return categoryDtos;
        }

        public CategoryDto GetCategoryById(Guid Id)
        {
            var category = categoryRepository.GetById(Id);
            return Mapper.Map<CategoryEntity, CategoryDto>(category);
        }

        public CategoryDto InsertCategory(CategoryDto categoryDto)
        {
            var category = Mapper.Map<CategoryEntity>(categoryDto);
            category = categoryRepository.Insert(category);
            categoryRepository.SaveChanges();

            return Mapper.Map<CategoryEntity, CategoryDto>(category);
        }

        public IList<CategoryDto> SearchCategoryByName(string categoryName, int pageIndex, int pageSize, out int total)
        {
            var category = categoryRepository.Search(p => p.Name.Contains(categoryName), o => o.Name, pageIndex, pageSize, out total);
            var categoryDtos = (IList<CategoryDto>)Mapper.Map(category, category.GetType(), typeof(IList<CategoryDto>));

            return categoryDtos;
        }

        public void UpdateCategory(CategoryDto categoryDto)
        {
            var category = Mapper.Map<CategoryEntity>(categoryDto);

            categoryRepository.Update(category);
            categoryRepository.SaveChanges();
        }
    }
}
