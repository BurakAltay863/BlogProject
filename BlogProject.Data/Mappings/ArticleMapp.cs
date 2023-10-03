using BlogProject.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BlogProject.Data.Mappings
{
    public class ArticleMapp : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net core projesi ",
                Content = " Asp.net core projesi Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ViewCount = 15,
                CategoryId= Guid.Parse("E215C0A4-1A05-46CF-80DF-5509E5C5C6AF"),
   
                ImageId= Guid.Parse("84C46E0F-5E3E-461D-B26A-F58342AC8AA2"),
                CretedBy = "Admin test",
                CreteDate = DateTime.Now,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual Studio Deb-neme Makelsi ",
                Content = " Visual Studio Deb-neme Makelsi  Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s, when an unknown printer took a galley of type and scrambled it to make a type specimen book. It has survived not only five centuries, but also the leap into electronic typesetting, remaining essentially unchanged. It was popularised in the 1960s with the release of Letraset sheets containing Lorem Ipsum passages, and more recently with desktop publishing software like Aldus PageMaker including versions of Lorem Ipsum",
                ViewCount = 15,
                CategoryId=Guid.Parse("C6AF89F7-5A41-43A1-B89D-4599C12FB1DA"),
                ImageId = Guid.Parse("92514E8B-B516-4AEB-BBCB-D1FE6E690542"),
                CretedBy = "Admin test",
                CreteDate = DateTime.Now,
                IsDeleted = false
            }
            );
        }
    }
}
