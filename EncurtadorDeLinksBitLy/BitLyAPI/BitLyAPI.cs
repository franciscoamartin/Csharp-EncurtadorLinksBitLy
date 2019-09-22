using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Net.Http;
using System.Net;
using Newtonsoft.Json;

namespace BitLyAPI
{

    //66479d04ab7e0ebed4cb248d6ecf0597d8311d44 access bitly token
    public class BitLyAPI
    {

        private string _bitLyApiUrl;
        private string _bitLyApiToken;

        public BitLyAPI()
        {
            _bitLyApiUrl = ConfigurationManager.AppSettings["BitLyAPIUrl"];
            _bitLyApiToken = ConfigurationManager.AppSettings["BitLyAPIToken"];
        }

        public async Task<string> ShortenAsync(string long_url)
        {
            return await Task.Run(() => Shorten(long_url));
        }
        private string Shorten(string long_url)
        {
            if (CheckAccessToken())
            {
                using (HttpClient client = new HttpClient())
                {
                    string temp = string.Format(_bitLyApiUrl, _bitLyApiToken, WebUtility.UrlEncode(long_url));
                    var response = client.GetAsync(temp).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var message = response.Content.ReadAsStringAsync().Result;
                        dynamic obj = JsonConvert.DeserializeObject(message);
                        return obj.results[long_url].shortUrl;
                    }
                    else
                    {
                        return "Não foi possível encurtar a URL.";
                    }
                }
            }
            else
            {
                return "Não foi possível encurtar a URL.";

            }
        }

        private bool CheckAccessToken()
        {
            if (string.IsNullOrEmpty(_bitLyApiToken))
                return false;

            string temp = string.Format(_bitLyApiUrl, _bitLyApiToken, "google.com");
            using (HttpClient client = new HttpClient())

            {
                HttpResponseMessage response = client.GetAsync(temp).Result;
                return response.IsSuccessStatusCode;

            }
        }
    }
}
