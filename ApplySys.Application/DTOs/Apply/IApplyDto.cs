using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using ApplySys.Application.DTOs.Common;

namespace ApplySys.Application.DTOs.Apply
{
    public abstract class IApplyDto
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public jobType JobType { get; set; }
        public state State { get; set; }
        public string Link { get; set; }

    }
}
