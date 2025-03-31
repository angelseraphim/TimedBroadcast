namespace TimedBroadcast
{
    using System;
    using System.Collections.Generic;

    using Exiled.API.Features;

    using MEC;

    using TimedBroadcast.EventHandlers;

    public class Plugin : Plugin<Config>
    {
        public override string Author => "angelseraphim.";
        public override string Name => "TimedBroadcast";
        public override string Prefix => "TimedBroadcast";
        public override Version Version => new Version(2, 0, 0);

        internal static readonly HashSet<CoroutineHandle> Coroutines = new HashSet<CoroutineHandle>();

        internal static Config config;

        private PlayerEvents playerEvents;
        private ServerEvents serverEvents;

        public override void OnEnabled()
        {
            config = Config;

            playerEvents = new PlayerEvents();
            serverEvents = new ServerEvents();

            playerEvents.Register();
            serverEvents.Register();

            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            config = null;

            playerEvents.UnRegister();
            serverEvents.UnRegister();

            playerEvents = null;
            serverEvents = null;

            base.OnDisabled();
        }

        public override void OnReloaded()
        {
            OnDisabled();
            OnEnabled();

            base.OnReloaded();
        }
    }
}
