
using System;
using URLShortenerProject.Model;

namespace URLShortenerProject.Services
{
    public class URLShortnerService : IUrlShortnerService
    {
        private const string Alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
        private readonly Random _random = new();

        public Task<string?> GetOriginalUrlAsync(string shortCode)
        {
            throw new NotImplementedException();
        }

        public Task<string> ShortenUrlAsync(string originalUrl)
        {
            // validate 
            // generate shprt URL  / code
            var shortcode = GenerateShortCode();
            // add prefix if needed
            var shortUrl = "newgen.ly" + shortcode;
            var mapping = new UrlMapping();
            mapping.ShortUrl = shortUrl;
            mapping.LongUrl = originalUrl ;
            // add into database 

            throw new NotImplementedException();
        }

        private string GenerateShortCode(int length = 6)
        {
            return new string(Enumerable.Repeat(Alphabet, length).Select(s => s[_random.Next(s.Length)]).ToArray());
        }
    }
}
