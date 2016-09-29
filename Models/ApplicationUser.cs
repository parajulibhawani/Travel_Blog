using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TravelBlog.Models
{
    public class ApplicationUser : IdentityUser
    {
        public bool MailingList { get; set; }

        public void AddToMailingList()
        {
            var client = new RestClient("https://us14.api.mailchimp.com/3.0");
            var request = new RestRequest("lists/23303acf33/members", Method.POST);
            request.AddJsonBody(new { status = "subscribed", email_address = Email });
            //request.AddHeader("contentType", "application/json");
            //request.RequestFormat = DataFormat.Json;
            //request.AddParameter("email_address", Email);
            //request.AddParameter("status", "subscribed");
            client.Authenticator = new HttpBasicAuthenticator("baxterc", "d40a134f30cad6d87395b7f434068dd0-us14");
            client.ExecuteAsync(request, response =>
            {
                Console.WriteLine(response.Content);
            });
           
        }
    }
}
