using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Data.Mappings
{
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
               
                    Id = Guid.Parse("84C46E0F-5E3E-461D-B26A-F58342AC8AA2"),
                    FileName = "images/testimage",
                    CretedBy = "Admin Test",
                    FileType = "jpg",
                    CreteDate = DateTime.Now,
                    IsDeleted = false
               
            },
            new Image
            {
               
                    Id = Guid.Parse("92514E8B-B516-4AEB-BBCB-D1FE6E690542"),
                    FileName = "images/vstest",
                    CretedBy = "Admin Test",
                    FileType = "png",
                    CreteDate = DateTime.Now,
                    IsDeleted = false
               
            });
           

        }
    }
}
