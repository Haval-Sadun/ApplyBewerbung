using ApplySys.MVC.Services.Base;

namespace ApplySys.MVC.Models
{
    public class ApplyVM : CreateApplyVM
    {
        public int Id { get; set; }
    }

    public class CreateApplyVM
    {
        public string Title { get; set; }
        public string CompanyName { get; set; }
        public JobType JobType { get; set; }
        public State State { get; set; }
        public DateTime DateCreated { get; set; }
        public string Link { get; set; }
    }
}
