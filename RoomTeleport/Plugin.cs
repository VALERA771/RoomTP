using Exiled.API.Features;
using System;

namespace RoomTP
{
    public class Plugin : Plugin<Config>
    {
        public override string Author { get; } = "VALERA771#1471";
        public override string Name { get; } = "Room Teleport";
        public override string Prefix { get; } = "RoomTP";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(5, 3, 0);

        public static Plugin Instance => singleton;
        private static Plugin singleton;

        public override void OnEnabled()
        {
            base.OnEnabled();

            Exiled.Events.Handlers.Server.RoundStarted += server.OnRoundStarted;

            Plugin.singleton = this;
        }

        public override void OnDisabled()
        {
            base.OnDisabled();

            Exiled.Events.Handlers.Server.RoundStarted -= server.OnRoundStarted;

            Plugin.singleton = null;
        }

        private RoomTP.Server server;

        private Plugin()
        {
        }
    }
}
