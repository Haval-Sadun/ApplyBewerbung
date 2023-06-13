using ApplySys.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply
{
    public class UpdateApplyDto: IApplyDto
    {

        public Guid Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public jobType JobType { get; set; }
        public state State { get; set; }
        public string Link { get; set; }
    }
}
