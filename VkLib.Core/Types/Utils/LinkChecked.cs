using System;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace VkLib.Types.Utils 
{
    public class LinkChecked
    {
        /// <summary>
        /// Link status
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// Link URL
        /// </summary>
        [JsonProperty("link")]
        public string Link { get; set; }

    }
}