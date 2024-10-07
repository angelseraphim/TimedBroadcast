using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;

namespace TimedBroadcast
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;
        [Description("Interval - Time after which the broadcast is repeated")]
        public List<Constructor> TimedBroadcasts { get; set; } = new List<Constructor>() { new Constructor(300, 10, "This server using Timedbroadcasts :3"), new Constructor(400, 10, "Something") };
    }
}
