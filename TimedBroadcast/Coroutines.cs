namespace TimedBroadcast
{
    using System.Collections.Generic;

    using Exiled.API.Features;

    using MEC;

    internal static class Coroutines
    {
        internal static IEnumerator<float> TimedBroadcasts(TimedBroadcasts timedBroadcasts)
        {
            while (true)
            {
                yield return Timing.WaitForSeconds(timedBroadcasts.Interval);

                Map.Broadcast(timedBroadcasts.Duration, timedBroadcasts.Text);
            }
        }
    }
}
