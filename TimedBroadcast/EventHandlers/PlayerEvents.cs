namespace TimedBroadcast.EventHandlers
{
    using Exiled.Events.EventArgs.Player;

    internal class PlayerEvents
    {
        internal void Register() => Exiled.Events.Handlers.Player.Verified += OnVerified;

        internal void UnRegister() => Exiled.Events.Handlers.Player.Verified -= OnVerified;

        private void OnVerified(VerifiedEventArgs ev)
        {
            if (ev.Player == null)
                return;

            ev.Player.Broadcast(Plugin.config.Duration, Plugin.config.Text);
        }
    }
}
