using ApplySys.Application.DTOs;
using ApplySys.Application.Contracts.Persistence;
using ApplySys.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Persistence.Repositories
{
    public class ApplyRepository : GenericRepository<Apply>, IApplyRepository
    {
        private readonly ApplyManagementDbContext _dbContext;

        public ApplyRepository(ApplyManagementDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

    }
}
