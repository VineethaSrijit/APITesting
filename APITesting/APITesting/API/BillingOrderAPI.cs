using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;

namespace APITesting.API
{
    class BillingOrderAPI
    {
        private readonly string url = "http://api.qaauto.co.nz/api/v1";

        public IRestResponse GetOrderbyId(string id)
        {
            //setting up
            var client = new RestClient($"{url}/billingOrders/{id}");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse PostOrder(string body)
        {
            //setting up
            var client = new RestClient($"{url}/billingOrders/");
            var request = new RestRequest(Method.POST);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse PutOrder(string body, string id)
        {
            //setting up
            var client = new RestClient($"{url}/billingOrders/{id}");
            var request = new RestRequest(Method.PUT);

            request.AddHeader("Content-Type", "application/json");
            request.AddParameter("application/json", body, ParameterType.RequestBody);

            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse DeleteOrderbyId(string id)
        {
            //setting up
            var client = new RestClient($"{url}/billingOrders/{id}");
            var request = new RestRequest(Method.DELETE);

            IRestResponse response = client.Execute(request);
            return response;
        }
        public IRestResponse GetAllOrders()
        {
            //setting up
            var client = new RestClient($"{url}/billingOrders/");
            var request = new RestRequest(Method.GET);

            IRestResponse response = client.Execute(request);
            return response;
        }
    }
}
