namespace TimedBroadcast.EventHandlers
{
    using MEC;

    internal class ServerEvents
    {
        internal void Register()
        {
            Exiled.Events.Handlers.Server.RoundStarted += OnRoundStarted;
            Exiled.Events.Handlers.Server.RestartingRound += OnRestartingRound;
        }

        internal void UnRegister()
        {
            Exiled.Events.Handlers.Server.RoundStarted -= OnRoundStarted;
            Exiled.Events.Handlers.Server.RestartingRound -= OnRestartingRound;
        }

        private void OnRestartingRound()
        {
            foreach (CoroutineHandle coroutine in Plugin.Coroutines)
            {
                Timing.KillCoroutines(coroutine);
            }

            Plugin.Coroutines.Clear();
        }

        private void OnRoundStarted()
        {
            foreach (TimedBroadcasts timedBroadcasts in Plugin.config.TimedBroadcasts)
            {
                Plugin.Coroutines.Add(Timing.RunCoroutine(Coroutines.TimedBroadcasts(timedBroadcasts)));
            }
        }
    }
}
