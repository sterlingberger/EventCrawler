using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace EventCrawler
{
    internal class Event
    {
        public string Venue { get; set; } = "unknown";

        public DateOnly Date { get; set; }

        public string Artist { get; set; } = "unknown";

        [JsonIgnore]
        public string Info { get; set; } = "unknown";

        public string Link { get; set; } = "unknown";

        //nur erste 50 zeichen nehmen
        public string InfoShort => Info.Length > 128 ? Info[..128] + "..." : Info;
    }
}
