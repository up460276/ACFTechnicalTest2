using ACFTechTest2.Models;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;

namespace ACFTechTest2.Classes
{
    public class API
    {

        public static testAPICollection Get()
        {
            //set up the collection of objects
            testAPICollection testAPIs = new testAPICollection();
            HttpClient httpclient = new HttpClient();
            HttpResponseMessage response = httpclient.GetAsync("https://jsonplaceholder.typicode.com/photos").Result;
            if (response.IsSuccessStatusCode)
            {
                testAPIs = JsonSerializer.Deserialize<testAPICollection>(response.Content.ReadAsStringAsync().Result);
            }
            return testAPIs;
        }
    }
}

