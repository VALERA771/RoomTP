using Exiled.API.Features;
using MEC;
namespace RoomTP
{
    internal class Server
    {
        public void OnRoundStarted()
        {
            while (Round.IsStarted)
            {
                Timing.CallDelayed(1, () =>
                {
                    foreach (Player player in Player.List)
                    {
                        if (player.CurrentRoom.Type == Plugin.Instance.Config.roomFr)
                            player.Teleport(Plugin.Instance.Config.roomTp);
                    }
                });
            }
        }
    }
}
