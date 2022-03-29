using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeeConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
             new Make
             {
                 Id = 1,
                 CreatedBy = "System",
                 DateCreated = DateTime.Now,
                 DateUpdate = DateTime.Now,
                 Name = "Série 1",
                 UpdateBy = "System"
             },
            new Make
            {
                Id = 2,
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                Name = "Série 3",
                UpdateBy = "System"
            },
            new Make
            {
                Id = 3,
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                Name = "Classe A Compacto",
                UpdateBy = "System"
            },
            new Make
            {
                Id = 4,
                CreatedBy = "System",
                DateCreated = DateTime.Now,
                DateUpdate = DateTime.Now,
                Name = "Classe B Tourer",
                UpdateBy = "System"
            }
             );
        }
    }
}
