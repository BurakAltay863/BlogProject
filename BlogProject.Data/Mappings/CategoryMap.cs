using BlogProjecet.Core.Entities;
using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogProject.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("E215C0A4-1A05-46CF-80DF-5509E5C5C6AF"),
                Name = "aSP.nETcORE",
                CretedBy = "Admin Test",
                CreteDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {

                Id = Guid.Parse("C6AF89F7-5A41-43A1-B89D-4599C12FB1DA"),
                Name = "Visual Studio 2022",
                CretedBy = "Admin Test",
                CreteDate = DateTime.Now,
                IsDeleted = false

            });
        }

    }
}
