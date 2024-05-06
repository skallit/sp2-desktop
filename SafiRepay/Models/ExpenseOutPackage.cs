using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.Models
{
    class ExpenseOutPackage
    {
        // Properties and Getter/Setters
        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Amount { get; set; }
        public string Unit { get; set; }
 




        // Construtor

        // Static methods for managing one or more records
        public static List<ExpenseOutPackage> All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("getExpenseOutPackages");

            // For debug
            Console.WriteLine("getExpenseOutPackages-All()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            List<ExpenseOutPackage> expenseOutPackage = JsonConvert.DeserializeObject<List<ExpenseOutPackage>>(response.Content);

            return expenseOutPackage;

        }
    }
}
