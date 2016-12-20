using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Leads 
{
    public class Complete
    {
        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("success")]
        public int? Success_ { get; set; }

        /// <summary>
        /// Amount of spent votes
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent_ { get; set; }

        /// <summary>
        /// Information whether test mode is enabled
        /// </summary>
        [JsonProperty("test_mode")]
        public int? TestMode { get; set; }

        /// <summary>
        /// Offer cost
        /// </summary>
        [JsonProperty("cost")]
        public int? Cost_ { get; set; }

        /// <summary>
        /// Offer limit
        /// </summary>
        [JsonProperty("limit")]
        public int? Limit_ { get; set; }

    }
}
