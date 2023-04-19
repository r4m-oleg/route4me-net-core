﻿using System.Xml.Linq;

namespace Route4MeSDK.QueryTypes
{
    /// <summary>
    ///     Parameters for the route address(es) request.
    /// </summary>
    /// <seealso cref="Route4MeSDK.QueryTypes.GenericParameters" />
    public sealed class AddressParameters : GenericParameters
    {
        /// <summary>
        ///     Unique ID of a route.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "route_id", EmitDefaultValue = false)]
        public string RouteId { get; set; }

        /// <summary>
        ///     Unique ID of a route destination.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "route_destination_id", EmitDefaultValue = false)]
        public long RouteDestinationId { get; set; }

        /// <summary>
        ///     Unique ID of a route destination.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "address_id", EmitDefaultValue = false)]
        public long AddressId { get; set; }

        /// <summary>
        ///     If true, the route destination notes will be included in a response.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "notes")]
        public bool Notes { get; set; }

        /// <summary>
        ///     If true, the route destination will be marked as departed.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "is_departed", EmitDefaultValue = false)]
        public bool? IsDeparted { get; set; }

        /// <summary>
        ///     If true, the route destination will be marked as visited.
        ///     <remarks>
        ///         <para>Query parameter.</para>
        ///     </remarks>
        /// </summary>
        [HttpQueryMemberAttribute(Name = "is_visited", EmitDefaultValue = false)]
        public bool? IsVisited { get; set; }

        /// <value>The member ID</value>
        [HttpQueryMemberAttribute(Name = "member_id", EmitDefaultValue = false)]
        public long? MemberId { get; set; }

        /// <summary>
        ///    Timestamp
        /// </summary>
        [HttpQueryMemberAttribute(Name = "utc_time", EmitDefaultValue = false)]
        public long? UtcTime { get; set; }

        /// <summary>
        ///     The position latitude
        /// </summary>
        [HttpQueryMemberAttribute(Name = "lat", EmitDefaultValue = false)]
        public double? Latitude { get; set; }

        /// <summary>
        ///     The position longitude
        /// </summary>
        [HttpQueryMemberAttribute(Name = "lng", EmitDefaultValue = false)]
        public double? Longitude { get; set; }
    }
}