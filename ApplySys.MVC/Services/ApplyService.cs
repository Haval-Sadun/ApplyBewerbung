using ApplySys.MVC.Contracts;
using ApplySys.MVC.Models;
using ApplySys.MVC.Services.Base;
using AutoMapper;

namespace ApplySys.MVC.Services
{
    public class ApplyService : BaseHttpService, IApplyService
    {
        private readonly ILocalStorageService _localStorageService;
        private readonly IMapper _mapper;
        private readonly IClient _httpclient;

        public ApplyService(ILocalStorageService localStorageService,
                            IMapper mapper,
                            IClient httpclient) : base(localStorageService, httpclient)
        {
            _localStorageService = localStorageService;
            _mapper = mapper;
            _httpclient = httpclient;
        }

        public async Task<Response<int>> CreateApply(CreateApplyVM apply)
        {
            try
            {
                var response = new Response<int>();
                CreateApplyDto createApply = _mapper.Map<CreateApplyDto>(apply);
                AddBearerToken();
                var apiResponse = await _httpclient.ApplyPOSTAsync(createApply);
                if (apiResponse.Success)
                {
                    response.Data = apiResponse.Id;
                    response.Success = true;
                }
                else
                {
                    foreach (var error in apiResponse.Errors)
                    {
                        response.ValidationErrors += error + Environment.NewLine;
                    }
                }
                return response;
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptiona<int>(ex);
            }
        }

        public async Task<Response<int>> DeleteApply(int id)
        {
            try
            {
                await _httpclient.ApplyDELETEAsync(id);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {

                return ConvertApiExceptiona<int>(ex);
            }
        }

        public async Task<ApplyVM> GetApplyDetails(int id)
        {
            var applys = await _httpclient.ApplyGETAsync(id);
            return _mapper.Map<ApplyVM>(applys);
        }

        public async Task<List<ApplyVM>> GetApplys()
        {
            var applys = await _httpclient.ApplyAllAsync();
            return _mapper.Map<List<ApplyVM>>(applys);
        }

        public async Task<Response<int>> UpdateApply(int id, ApplyVM apply)
        {
            try
            {
                var applyDto = _mapper.Map<UpdateApplyDto>(apply);
                await _httpclient.ApplyPUTAsync(id, applyDto);
                return new Response<int> { Success = true };
            }
            catch (ApiException ex)
            {
                return ConvertApiExceptiona<int>(ex);
            }
        }
    }
}
