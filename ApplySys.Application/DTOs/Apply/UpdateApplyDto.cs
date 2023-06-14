using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply
{
    public class UpdateApplyDto: IApplyDto
    {

        public int Id { get; set; }
        public DateTime LastModifiedDate { get; set; }

    }
}
