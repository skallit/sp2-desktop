using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.Models
{
    class ExpensePackageType
    {
        // Properties and Getter/Setters
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
        // Construtor

        // Static methods for managing one or more records
        public static List<ExpensePackageType> All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("getExpensePackageTypes");

            // For debug
            Console.WriteLine("ExpensePackageType-All()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            List<ExpensePackageType> expensePackageType = JsonConvert.DeserializeObject<List<ExpensePackageType>>(response.Content);

            return expensePackageType;

        }

        // Object methods for managing a object instance of this class

        public static String Update(int IdExpensePackageType, decimal Amount)
        {
            // Call the secure HTTP GET request with an id parameter
            IRestResponse response = Api.PostWithToken("postExpensePackageType/{id}", new Dictionary<string, string>() { { "id", IdExpensePackageType.ToString() }, { "amount", Amount.ToString()} } );

            // For debug
            Console.WriteLine("ExpensePackageType-Find({0})", IdExpensePackageType);
            Console.WriteLine(response.Content);

            // Create a object instance of the class using the JSON response
            ExpensePackageType expensePackageType = JsonConvert.DeserializeObject<ExpensePackageType>(response.Content);

            // Assign a message according to the response status code
            String message;
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    message = "Success";
                    break;
                case System.Net.HttpStatusCode.Unauthorized:
                    message = "You are not allowed ! Please try again !";
                    break;
                default:
                    message = "Oups ! There is a problem with your internet connection !";
                    break;
            }

            return message;
        }
    }
}
