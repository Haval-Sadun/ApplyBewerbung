using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Application.DTOs.Apply
{
    public class ApplyDto : IApplyDto
    {
        public int Id { get; set; }
        public DateTime DateCreated { get; set; }
        public DateTime? LastModifiedDate { get; set; }

    }
}
