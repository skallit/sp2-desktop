using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.Models
{
    class ExpenseInPackage
    {
        // Properties and Getter/Setters
        public int Id { get; set; }
        public int Expensepackagetype_id { get; set; }


        // Construtor

        // Static methods for managing one or more records
        public static List<ExpenseInPackage> All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("getExpenseInPackages");

            // For debug
            Console.WriteLine("getExpenseInPackages-All()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            List<ExpenseInPackage> expenseInPackage = JsonConvert.DeserializeObject<List<ExpenseInPackage>>(response.Content);

            return expenseInPackage;

        }
    }
}
