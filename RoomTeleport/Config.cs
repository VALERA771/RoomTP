using Exiled.API.Enums;
using Exiled.API.Interfaces;
using System.ComponentModel;

namespace RoomTP
{
    public sealed class Config : IConfig
    {
        public bool IsEnabled { get; set; } = true;

        [Description("In which room should be trigger")]
        public RoomType roomFr { get; set; } = RoomType.HczChkpA;

        [Description("In which room should player be teleported")]
        public RoomType roomTp { get; set; } = RoomType.HczChkpB;
    }
}
