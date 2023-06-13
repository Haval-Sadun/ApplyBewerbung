using ApplySys.Domain.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplySys.Domain.Entities
{
    public sealed class Apply 
    {

        public int Id { get; set; }
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public jobType JobType { get; set; }
        public state State { get; set; }
        public DateTime Date { get; set; }
        public string Link { get; set; }
    }
}

        //private Apply(Guid id, string title, string companyName, jobType jobType, state state, DateTime date, string link) : base(id)
        //{
        //    Title= title;
        //    CompanyName= companyName;
        //    JobType= jobType;
        //    State= state;
        //    Date= date;
        //    Link= link;
        //}