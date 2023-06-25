using Newtonsoft.Json;

namespace Zip_Code_App_Project
{
    /// <summary>
    /// Object model used for getting the place name and the state for the given zip code
    /// </summary>
    public class LocationInformation
    {
        // using JsonProperty since place name had white space
        [JsonProperty("place name")]
        public string PlaceName { get; set; }
        [JsonProperty("state")]
        public string State { get; set; }
    }
}
