using Autofac;
using AutoMapper;
using StudentManagement.Business.Contracts;
using StudentManagement.Business.Dtos;
using StudentManagement.Data;
using StudentManagement.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Business
{
    public class BusinessModule : Module
    {
        private string connectionString;
        public BusinessModule(string connString)
        {
            connectionString = connString;
            RegisterMapper();
        }

        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<UserBusinessService>().As<IUserBusinessService>().InstancePerRequest();
            builder.RegisterType<BlogBusinessService>().As<IBlogBusinessService>().InstancePerRequest();
            builder.RegisterType<ImageBusinessService>().As<IImageBusinessService>().InstancePerRequest();
            builder.RegisterType<CommentBusinessService>().As<ICommentBusinessService>().InstancePerRequest();
            builder.RegisterType<RoleBusinessService>().As<IRoleBusinessService>().InstancePerRequest();
            builder.RegisterType<CategoryBusinessService>().As<ICategoryBusinessService>().InstancePerRequest();

            builder.RegisterModule(new DataModule(connectionString));
            base.Load(builder);
        }

        private void RegisterMapper()
        {
            Mapper.CreateMap<BaseEntity, BaseDto>();
            Mapper.CreateMap<BaseDto, BaseEntity>();

            Mapper.CreateMap<UserEntity, UserDto>();
            Mapper.CreateMap<UserDto, UserEntity>();

            Mapper.CreateMap<CategoryEntity, CategoryDto>();
            Mapper.CreateMap<CategoryDto, CategoryEntity>();

            Mapper.CreateMap<RoleEntity, RoleDto>();
            Mapper.CreateMap<RoleDto, RoleEntity>();

            Mapper.CreateMap<BlogEntity, BlogDto>();
            Mapper.CreateMap<BlogDto, BlogEntity>();

            Mapper.CreateMap<ImageEntity, ImageDto>();
            Mapper.CreateMap<ImageDto, ImageEntity>();

            Mapper.CreateMap<CommentEntity, CommentDto>();
            Mapper.CreateMap<CommentDto, CommentEntity>();
        }
    }
}
