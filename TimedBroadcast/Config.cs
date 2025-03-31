namespace TimedBroadcast
{
    using System.ComponentModel;

    using Exiled.API.Interfaces;

    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        [Description("On player join broadcast")]
        public ushort Duration { get; set; } = 10;
        public string Text { get; set; } = "Привет!";

        [Description("Timed broadcasts")]
        public TimedBroadcasts[] TimedBroadcasts { get; set; } = new TimedBroadcasts[]
        {
            new TimedBroadcasts(300, 5, "Заходите к нас в Discord!"),
            new TimedBroadcasts(600, 10, "Приходите к нам на админку!!!")
        };
    }
}
