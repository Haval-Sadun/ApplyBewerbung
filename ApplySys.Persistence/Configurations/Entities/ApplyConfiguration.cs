using ApplySys.Domain;
using ApplySys.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Persistence.Configurations.Entities
{
    internal class ApplyConfiguration : IEntityTypeConfiguration<Apply>
    {
        public void Configure(EntityTypeBuilder<Apply> builder)
        {
            _ = builder.HasData(
                    new Apply
                    {
                        Id = new Guid("5fb7097c-335c-4d07-b4fd-000004e2d28c"),
                        Title = "Softwareentwickler",
                        CompanyName = "Xitaso",
                        Date = DateTime.Now,
                        JobType = jobType.fullTime,
                        Link = "hier goes the link ",
                        State = state.inProgress
                    }
                );
        }
    }
}
