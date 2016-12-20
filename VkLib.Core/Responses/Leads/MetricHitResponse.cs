using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using VkLib.Types;

namespace VkLib.Responses.Leads
{
    public class MetricHitResponse
    {
        /// <summary>
        /// Redirect link
        /// </summary>
        [JsonProperty("redirect_link")]
        public string RedirectLink { get; set; }

        /// <summary>
        /// Information whether request has been processed successfully
        /// </summary>
        [JsonProperty("result")]
        public bool? Result { get; set; }

    }
}
