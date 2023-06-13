using ApplySys.Application.DTOs.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply
{
    public class CreateApplyDto : IApplyDto
    {
        public DateTime Date { get; set; }
    }
}
