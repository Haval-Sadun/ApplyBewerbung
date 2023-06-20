using ApplySys.MVC.Models;
using ApplySys.MVC.Services.Base;

namespace ApplySys.MVC.Contracts
{
    public interface IApplyService
    {
        Task<List<ApplyVM>> GetApplys();
        Task<ApplyVM> GetApplyDetails(int id);
        Task<Response<int>> CreateApply(CreateApplyVM apply);
        Task<Response<int>> UpdateApply(int id, ApplyVM apply);
        Task<Response<int>> DeleteApply(int id);
    }
}
