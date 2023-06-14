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
                        Id = 2,
                        Title = "Softwareentwickler",
                        CompanyName = "Xitaso",
                        DateCreated = DateTime.Now,
                        JobType = jobType.fullTime,
                        Link = "hier goes the link ",
                        State = state.inProgress
                    }
                );
        }
    }
}
