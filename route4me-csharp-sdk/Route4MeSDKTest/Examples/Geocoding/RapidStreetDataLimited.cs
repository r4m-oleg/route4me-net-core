﻿using Route4MeSDK.QueryTypes;
using System;
using System.Collections;
using System.Collections.Generic;

namespace Route4MeSDK.Examples
{
    public sealed partial class Route4MeExamples
    {
        /// <summary>
        /// Rapid Street Data Limited
        /// </summary>
        public void RapidStreetDataLimited()
        {
            // Create the manager with the api key
            var route4Me = new Route4MeManager(ActualApiKey);

            var geoParams = new GeocodingParameters()
            {
                Offset = 10,
                Limit = 10
            };

            // Run the query
            ArrayList result = route4Me.RapidStreetData(geoParams, out string errorString);

            Console.WriteLine("");

            if (result != null)
            {
                Console.WriteLine("RapidStreetDataLimited executed successfully");

                foreach (Dictionary<string, string> res1 in result)
                {
                    Console.WriteLine("Zipcode: " + res1["zipcode"]);
                    Console.WriteLine("Street name: " + res1["street_name"]);
                    Console.WriteLine("---------------------------");
                }
            }
            else
            {
                Console.WriteLine("RapidStreetDataLimited error: {0}", errorString);
            }
        }
    }
}
