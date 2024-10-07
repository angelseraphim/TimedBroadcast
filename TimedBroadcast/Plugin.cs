using Exiled.API.Features;
using MEC;
using System.Collections.Generic;

namespace TimedBroadcast
{
    public class Plugin : Plugin<Config>
    {
        public override string Prefix => "TimedBroadcast";
        public override string Name => "TimedBroadcast";
        public override string Author => "angelseraphim.";

        private readonly List<CoroutineHandle> CoroutineList = new List<CoroutineHandle>();

        public static Plugin plugin;
        public static Coroutines coroutines;

        public override void OnEnabled()
        {
            plugin = this;
            coroutines = new Coroutines();

            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
            Exiled.Events.Handlers.Server.RestartingRound += OnRestartingRound;
            base.OnEnabled();
        }
        public override void OnDisabled()
        {
            plugin = null;
            coroutines = null;

            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            Exiled.Events.Handlers.Server.RestartingRound -= OnRestartingRound;
            base.OnDisabled();
        }
        private void OnRestartingRound()
        {
            foreach (CoroutineHandle coroutine in CoroutineList)
            {
                Timing.KillCoroutines(coroutine);
            }
            CoroutineList.Clear();
        }
        private void OnRoundStarted()
        {
            foreach (Constructor broadcasts in Config.TimedBroadcasts)
            {
                CoroutineList.Add(Timing.RunCoroutine(coroutines.TimedBroadcast(broadcasts)));
            }
        }
    }
}
