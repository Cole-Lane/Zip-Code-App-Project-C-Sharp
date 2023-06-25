using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Zip_Code_App_Project
{
    /// <summary>
    /// Helper class to process the request from the zippopotam.us API.
    /// Appends the given zipCode (from the zip code text box) to the base URL for US zip codes.
    /// Then turns the response into a string in order to process the data.
    /// </summary>
    public class ZippoProcessor
    {
        public static async Task<LocationInformation> LoadZip(string zipCode)
        {   // append the given zip code to the base address 
            using (HttpResponseMessage response = await ApiHelper.ApiClient.GetAsync($"{ApiHelper.ApiClient.BaseAddress}{zipCode}"))
            {
                // check for success response code (200's)
                if (response.IsSuccessStatusCode)
                {
                    string ResponseString = await response.Content.ReadAsStringAsync();
                    ZipModel zip = JsonConvert.DeserializeObject<ZipModel>(ResponseString);
                    return zip.Places[0];
                }
                // throw error if response is not successful
                else
                {
                    throw new Exception(response.ReasonPhrase);
                }
            }
        }
    }
}
