using System.Collections.Generic;
using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API UsersArray object.
    /// </summary>
    public class UsersArray
    {
        /// <summary>
        /// Users number
        /// </summary>
        [JsonProperty("count")]
        public int? Count { get; set; }

        /// <summary>
        /// Property
        /// </summary>
        [JsonProperty("items")]
        public IEnumerable<int?> Items { get; set; }
    }
}