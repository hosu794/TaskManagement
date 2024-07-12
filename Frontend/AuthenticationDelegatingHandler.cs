using System.Net.Http.Headers;

namespace Frontend
{
    public class AuthenticationDelegatingHandler : DelegatingHandler
    {
        private string _token;

        public void SetToken(string token)
        {
            _token = token;
        }

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            if (!string.IsNullOrEmpty(_token))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", _token);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
