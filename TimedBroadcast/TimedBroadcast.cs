namespace TimedBroadcast
{
    public class TimedBroadcasts
    {
        public int Interval { get; set; }
        public ushort Duration { get; set; }
        public string Text { get; set; }

        public TimedBroadcasts() { }

        public TimedBroadcasts(int interval, ushort duration, string text)
        {
            Text = text;
            Interval = interval;
            Duration = duration;
        }
    }
}
