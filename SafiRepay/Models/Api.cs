using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;

namespace SafiRepay.Models
{
    class Api
    {
        private static string _url = Properties.Resources.API_URL;
        public static IRestResponse Post(String route, Dictionary<String, String> fields = null)
        {
            // The HTTP instance object where to send the request
            RestClient clientApi = new RestClient(Api._url);

            // Prepare the request
            RestRequest request = new RestRequest(Method.POST);
            request.Resource = route;
            request.AddJsonBody(fields);

            // Send the HTTP request and return the response
            return clientApi.Execute(request);
        }
        public static void GetWithToken(String route, Dictionary<String, String> fields = null)
        {

        }
    }
}
