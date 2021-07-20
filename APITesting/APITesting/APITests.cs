using APITesting.API;
using NUnit.Framework;
using RestSharp;

namespace APITesting
{
    public class Tests
    {
        [Test]
        public void TC_GetOrder()
        {
            BillingOrderAPI billingOrder = new BillingOrderAPI();
            IRestResponse response = billingOrder.GetOrderbyId("150");
            TestContext.WriteLine(response.Content);
            //assertions to be done
        }
        [Test]
        public void TC_PostOrder()
        {
            for (int i = 1; i <= 100; i++)
            {
                string body = "{{\"id\":{i},\"FirstName\":\"Csharp{i}\",\"LastName\":\"Stark\",\"Email\":\"as@gmail.com\",\"AddressLine1\":\"North\",\"AddressLine2\":\"Europe\",\"PhoneNumber\":\"99559955\",\"Comment\":\"testing\",\"ZipCode\":\"5400\"}}";
                BillingOrderAPI billingOrder = new BillingOrderAPI();
                IRestResponse response = billingOrder.PostOrder(body);
                TestContext.WriteLine(response.Content);
            }
            //assertions to be done
        }
        [Test]
        public void TC_PutOrder()
        {
            string body = $"{{\"id\": 1,\"FirstName\":\"Csharp\",\"LastName\":\"Stark\",\"Email\":\"as@gmail.com\",\"AddressLine1\":\"North\",\"AddressLine2\":\"Europe\",\"PhoneNumber\":\"99559955\",\"Comment\":\"testing\",\"ZipCode\":\"5400\"}}";
            BillingOrderAPI billingOrder = new BillingOrderAPI();
            //to-do
            IRestResponse response = billingOrder.PutOrder("150", body);
            TestContext.WriteLine(response.Content);
            //assertions to be done
        }
        [Test]
        public void TC_DeleteOrder()
        {
            BillingOrderAPI billingOrder = new BillingOrderAPI();
            IRestResponse response = billingOrder.DeleteOrderbyId("150");
            TestContext.WriteLine(response.Content);
            //assertions to be done
        }
        [Test]
        public void TC_GetAllOrders()
        {
            BillingOrderAPI billingOrder = new BillingOrderAPI();
            IRestResponse response = billingOrder.GetAllOrders();
            TestContext.WriteLine(response.Content);
            //assertions to be done
        }
    }
}