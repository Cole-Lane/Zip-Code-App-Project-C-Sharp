namespace Zip_Code_App_Project
{
    /// <summary>
    /// Object model to store the response from the zippopotam.us API
    /// Uses the LocationInformation class to store information returned under the places object array
    /// </summary>
    public class ZipModel
    {
        public LocationInformation[] Places { get; set; }
    }
}
