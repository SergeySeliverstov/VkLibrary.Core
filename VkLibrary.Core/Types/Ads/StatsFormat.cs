using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Ads
{
    /// <summary>
    /// API StatsFormat object.
    /// </summary>
    public class StatsFormat
    {
        /// <summary>
        /// Video views (full video)
        /// </summary>
        [JsonProperty("video_views_full")]
        public int? VideoViewsFull { get; set; }

        /// <summary>
        /// Video views number
        /// </summary>
        [JsonProperty("video_views")]
        public int? VideoViews { get; set; }

        /// <summary>
        /// 1 if period=overall
        /// </summary>
        [JsonProperty("overall")]
        public int? Overall { get; set; }

        /// <summary>
        /// Clickthoughs to the advertised site
        /// </summary>
        [JsonProperty("video_clicks_site")]
        public int? VideoClicksSite { get; set; }

        /// <summary>
        /// Day as YYYY-MM-DD
        /// </summary>
        [JsonProperty("day")]
        public string Day { get; set; }

        /// <summary>
        /// Reach
        /// </summary>
        [JsonProperty("reach")]
        public int? Reach { get; set; }

        /// <summary>
        /// Impressions number
        /// </summary>
        [JsonProperty("impressions")]
        public int? Impressions { get; set; }

        /// <summary>
        /// Clicks number
        /// </summary>
        [JsonProperty("clicks")]
        public int? Clicks { get; set; }

        /// <summary>
        /// Video views (half of video)
        /// </summary>
        [JsonProperty("video_views_half")]
        public int? VideoViewsHalf { get; set; }

        /// <summary>
        /// Spent funds
        /// </summary>
        [JsonProperty("spent")]
        public int? Spent { get; set; }

        /// <summary>
        /// Events number
        /// </summary>
        [JsonProperty("join_rate")]
        public int? JoinRate { get; set; }

        /// <summary>
        /// Month as YYYY-MM
        /// </summary>
        [JsonProperty("month")]
        public string Month { get; set; }
    }
}