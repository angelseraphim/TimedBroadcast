using Exiled.API.Features;
using MEC;
using System.Collections.Generic;

namespace TimedBroadcast
{
    public class Coroutines
    {
        public IEnumerator<float> TimedBroadcast(Constructor broadcast)
        {
            while (!Round.IsEnded)
            {
                yield return Timing.WaitForSeconds(broadcast.Interval);
                Map.Broadcast(broadcast.Duration, broadcast.Text);
            }
            yield break;
        }
    }
}
