﻿using Route4MeSDK.DataTypes;
using Route4MeSDK.QueryTypes;
using System;

namespace Route4MeSDK.Examples
{
    public sealed partial class Route4MeExamples
    {
        /// <summary>
        /// Get Orders by Scheduled Date
        /// </summary>
        public void GetOrderByScheduledDate(string ScheduleddDate)
        {
            // Create the manager with the api key
            var route4Me = new Route4MeManager(ActualApiKey);

            var oParams = new OrderParameters { ScheduledForYYMMDD = ScheduleddDate };

            Order[] orders = route4Me.SearchOrders(oParams, out string errorString);

            Console.WriteLine("");

            if (orders != null)
            {
                Console.WriteLine("GetOrderByScheduledDate executed successfully, orders searched total = {0}", orders.Length);
            }
            else
            {
                Console.WriteLine("GetOrderByScheduledDate error: {0}", errorString);
            }
        }
    }
}
