namespace TimedBroadcast
{
    public class Constructor
    {
        public int Interval { get; set; }
        public ushort Duration { get; set; }
        public string Text { get; set; }

        public Constructor() { }
        public Constructor(int Interval, ushort Duration, string Text)
        {
            this.Interval = Interval;
            this.Duration = Duration;
            this.Text = Text;
        }
    }
}
