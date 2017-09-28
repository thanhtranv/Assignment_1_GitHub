using StudentManagement.Business.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business.Contracts
{
    public interface IImageBusinessService
    {
        IList<ImageDto> GetAllImages();
        //IList<ImageDto> SearchImageByName(string imageName, int pageIndex, int pageSize, out int total);
        ImageDto InsertImage(ImageDto imageDto);
        void UpdateImage(ImageDto imageDto);
        void DeleteImage(ImageDto imageDto);
        ImageDto GetImageById(Guid Id);
    }
}
