using System;
using System.Security.Cryptography;
using System.Text;

namespace TravelAgencyDemo.Hotelsbed.Authentication
{
    public sealed class GetAuthenticed
    {
        private static string _signature;

        public static string Signature()
        {
            const string apiKey = "9g9e3fpc5ea8e692pdznrk52";
            const string Secret = "hC4G64FvN9";

            using (var sha = SHA256.Create())
            {
                long ts = (long)(DateTime.UtcNow - new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc)).TotalMilliseconds / 1000;
                Console.WriteLine("Timestamp: " + ts);
                var computedHash = sha.ComputeHash(Encoding.UTF8.GetBytes(apiKey + Secret + ts));
                _signature = BitConverter.ToString(computedHash).Replace("-", "");

            }


            return _signature;

        }
}


    }
