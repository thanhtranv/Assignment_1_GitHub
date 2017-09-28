using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;


namespace StudentManagement.Business
{
    public class ImageBusinessService : BaseBusinessService, IImageBusinessService
    {
        private IRepository<ImageEntity> imageRepository;

        public ImageBusinessService(IRepository<ImageEntity> repo)
        {
            imageRepository = repo;
        }

        public void DeleteImage(ImageDto imageDto)
        {
            var image = Mapper.Map<ImageEntity>(imageDto);

            imageRepository.Delete(image);
            imageRepository.SaveChanges();
        }

        public IList<ImageDto> GetAllImages()
        {
            var image = imageRepository.GetAll();
            var imageDtos = (IList<ImageDto>)Mapper.Map(image, image.GetType(), typeof(IList<ImageDto>));
            return imageDtos;
        }

        public ImageDto GetImageById(Guid Id)
        {
            var image = imageRepository.GetById(Id);
            return Mapper.Map<ImageEntity, ImageDto>(image);
        }

        public ImageDto InsertImage(ImageDto imageDto)
        {
            var image = Mapper.Map<ImageEntity>(imageDto);
            image = imageRepository.Insert(image);
            imageRepository.SaveChanges();

            return Mapper.Map<ImageEntity, ImageDto>(image);
        }

        //public IList<ImageDto> SearchCategoryByName(string categoryName, int pageIndex, int pageSize, out int total)
        //{
        //    var category = categoryRepository.Search(p => p.Name.Contains(categoryName), o => o.Name, pageIndex, pageSize, out total);
        //    var categoryDtos = (IList<CategoryDto>)Mapper.Map(category, category.GetType(), typeof(IList<CategoryDto>));

        //    return categoryDtos;
        //}

        public void UpdateImage(ImageDto imageDto)
        {
            var image = Mapper.Map<ImageEntity>(imageDto);

            imageRepository.Update(image);
            imageRepository.SaveChanges();
        }
    }
}
