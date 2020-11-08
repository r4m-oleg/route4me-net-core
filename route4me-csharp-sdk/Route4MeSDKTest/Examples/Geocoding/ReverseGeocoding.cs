﻿using Route4MeSDK.QueryTypes;

namespace Route4MeSDK.Examples
{
    public sealed partial class Route4MeExamples
    {
        /// <summary>
        /// Reverse Geocoding
        /// </summary>
        /// <returns> json/xml object </returns>
        public void ReverseGeocoding()
        {
            // Create the manager with the api key
            var route4Me = new Route4MeManager(ActualApiKey);

            var geoParams = new GeocodingParameters
            {
                Addresses = "42.35863,-71.05670",
                Format = "json"
            };

            // Run the query
            string result = route4Me.Geocoding(geoParams, out string errorString);

            PrintExampleGeocodings(result, GeocodingPrintOption.Geocodings, errorString);
        }
    }
}
