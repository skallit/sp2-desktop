using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafiRepay.Models
{
    class User
    {
        public static String Register(String firstname, String lastname, String email, String pwd)
        {

            // Create an associative array with the email and the password
            Dictionary<String, String> newUser = new Dictionary<string, string>();
            newUser.Add("firstname", firstname);
            newUser.Add("lastname", lastname);
            newUser.Add("email", email);
            newUser.Add("password", pwd);

            // Call /login route to the API
            IRestResponse response = Api.Post("register", newUser);

            // Print the response content into the console
            Console.WriteLine(response.Content);

            // Assign a message according to the response status code
            String message;
            switch (response.StatusCode)
            {
                case System.Net.HttpStatusCode.OK:
                    message = "L'utilisateur à été créer avec succés";
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
