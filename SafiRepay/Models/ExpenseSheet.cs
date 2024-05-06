using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.Models
{
    class ExpenseSheet
    {
        // Properties and Getter/Setters
        public int Id { get; set; }
        public string Ref { get; set; }
        public decimal CalculatedAmount { get; set; }
        public string Unit { get; set; }

        // Construtor

        // Static methods for managing one or more records
        public static List<ExpenseSheet> All()
        {
            // Call the secure HTTP GET request
            IRestResponse response = Api.GetWithToken("getExpenseSheetClosed");

            // For debug
            Console.WriteLine("getExpenseSheetClosed-All()");
            Console.WriteLine(response.Content);

            // Create a array of objects instances of the class using the JSON response
            List<ExpenseSheet> expenseSheet = JsonConvert.DeserializeObject<List<ExpenseSheet>>(response.Content);

            return expenseSheet;

        }
    }
}
