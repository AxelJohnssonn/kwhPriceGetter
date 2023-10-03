using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace PriceApp
{
    internal class Curl
    {
        private FormUrlEncodedContent requestContent;
        private HttpClient curl;
        private List<String> output;
        public Curl ()
        {
            curl = new HttpClient ();
            output = new List<string>();
            requestContent = new FormUrlEncodedContent(new[] {
            new KeyValuePair<string, string>("text", "This is a block of text"),
            });
        }

        public async void getPrice()
        {   

            HttpResponseMessage response = await curl.PostAsync("https://www.elprisetjustnu.se/api/v1/prices/2023/09-24_SE4.json", requestContent);
            HttpContent responseContent = response.Content;

            using (var reader = new StreamReader(await responseContent.ReadAsStreamAsync()))
            {
                // Write the output.
                //Console.WriteLine(await reader.ReadToEndAsync());
                output.Add(await reader.ReadToEndAsync());
            }
        }

        public string parsePrice(String year, String month, String day)
        {
            return null;
        }

        public List<String> getOutput()
        {   
            
            return output;
        }

    }
}
