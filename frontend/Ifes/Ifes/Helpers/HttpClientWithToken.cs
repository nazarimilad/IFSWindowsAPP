using Ifes.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Ifes.Helpers {
   public static class HttpClientWithToken {

        public static HttpClient GetClient() {
            var client = new HttpClient();
            client.DefaultRequestHeaders.Authorization
              = new AuthenticationHeaderValue("Bearer", AuthenticationService.Instance.JwtToken);
            return client;
        }
    }
}
