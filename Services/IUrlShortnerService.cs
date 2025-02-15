namespace URLShortenerProject.Services
{
    /// <summary>
    /// Interface layer for the URL Service.
    /// </summary>
    public interface IUrlShortnerService
    {
        /// <summary>
        /// Method which will perfrom the shortning of the Long URL provided.
        /// </summary>
        /// <param name="originalUrl">Instance of the string.</param>
        /// <returns>Instance of the string indicating shortned url for long URL.</returns>
        Task<string> ShortenUrlAsync(string originalUrl);

        /// <summary>
        /// Method will return the valid long URL for given short URL.
        /// </summary>
        /// <param name="shortCode">Instance of the string.</param>
        /// <returns>Instance of the string represernting the long URL for given short URL</returns>
        Task<string?> GetOriginalUrlAsync(string shortCode);
    }
}
