using Newtonsoft.Json;

namespace VkLibrary.Core.Types.Users
{
    /// <summary>
    /// API CropPhotoRect object.
    /// </summary>
    public class CropPhotoRect
    {
        /// <summary>
        /// Coordinate Y of the right lower corner
        /// </summary>
        [JsonProperty("y2")]
        public uint? Y2 { get; set; }

        /// <summary>
        /// Coordinate X of the right lower corner
        /// </summary>
        [JsonProperty("x2")]
        public uint? X2 { get; set; }

        /// <summary>
        /// Coordinate Y of the left upper corner
        /// </summary>
        [JsonProperty("y")]
        public uint? Y { get; set; }

        /// <summary>
        /// Coordinate X of the left upper corner
        /// </summary>
        [JsonProperty("x")]
        public uint? X { get; set; }
    }
}