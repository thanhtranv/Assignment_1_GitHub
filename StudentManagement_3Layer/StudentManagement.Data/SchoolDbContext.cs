using StudentManagement.Data.Contracts;
using StudentManagement.Data.Entities;
using StudentManagement.Data.Mapping;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement.Data
{
    public class SchoolDbContext : DbContext, IDbContext
    {
        public SchoolDbContext() : base("DefaultDb")
        {

        }

        public SchoolDbContext(string connectString) : base(connectString)
        {

        }

        public IDbSet<TEntity> Set<TEntity>() where TEntity : BaseEntity
        {
            return base.Set<TEntity>();
        }

        public DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : BaseEntity
        {
            return base.Entry(entity);
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new BlogMapping());
            modelBuilder.Configurations.Add(new RoleMapping());
            modelBuilder.Configurations.Add(new CommentMapping());
            modelBuilder.Configurations.Add(new ImageMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
