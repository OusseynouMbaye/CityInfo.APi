namespace CityInfo.API.Models
{
    /// <summary>
    /// A DTO a city without points of interest
    /// </summary>
    public class CityWithoutPointOfInterestDto
    {
        /// <summary>
        /// The id of city
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// The name of city
        /// </summary>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// The description of city
        /// </summary>
        public string? Description { get; set; }
    }
}
