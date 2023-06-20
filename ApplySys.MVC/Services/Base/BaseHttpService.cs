using ApplySys.MVC.Contracts;
using System.Net.Http.Headers;

namespace ApplySys.MVC.Services.Base
{
    public class BaseHttpService
    {
        protected readonly ILocalStorageService _localStorage;
        protected IClient _client;
        public BaseHttpService(ILocalStorageService localStorage, IClient client)
        {
            _localStorage = localStorage;
            _client = client;
        }

        protected Response<Guid> ConvertApiExceptiona<Guid>(ApiException ex)
        {
            if (ex.StatusCode == 400)
            {
                return new Response<Guid>() { Message = "Validation Errors have occured", ValidationErrors = ex.Response, Success = false };
            }
            else if (ex.StatusCode == 404)
            {
                return new Response<Guid>() { Message = "Requested item could not be found", Success = false };
            }
            else
            {
                return new Response<Guid>() { Message = "sth went wrong please try again later", Success = false };
            }
        }

        protected void AddBearerToken()
        {
            if (_localStorage.Exists("token"))
            {
                _client.HttpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _localStorage.GetStorageValue<string>("token"));
            }
        }
    }
}
