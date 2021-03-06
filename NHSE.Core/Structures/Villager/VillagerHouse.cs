﻿using System.Runtime.InteropServices;

namespace NHSE.Core
{
    [StructLayout(LayoutKind.Explicit, Size = SIZE, Pack = 4)]
    public class VillagerHouse : IHouseInfo
{
        public const int SIZE = 0x1D4;
        public const int ItemCount = 36;

        [field: FieldOffset(0x000)] public uint HouseLevel { get; set; }
        [field: FieldOffset(0x004)] public uint HouseStatus { get; set; }
        [field: FieldOffset(0x008)] public ushort WallUniqueID { get; set; }
        [field: FieldOffset(0x00A)] public ushort RoofUniqueID { get; set; }
        [field: FieldOffset(0x00C)] public ushort DoorUniqueID { get; set; }
        [field: FieldOffset(0x00E)] public ushort OrderWallUniqueID { get; set; }
        [field: FieldOffset(0x010)] public ushort OrderRoofUniqueID { get; set; }
        [field: FieldOffset(0x012)] public ushort OrderDoorUniqueID { get; set; }

        [field: FieldOffset(0x1C4)] public sbyte NPC1 { get; set; }
        [field: FieldOffset(0x1C5)] public sbyte NPC2 { get; set; }

        [field: FieldOffset(0x1C8)] public GSaveItemName DoorDecoItemName { get; set; }
        [field: FieldOffset(0x1D0)] public sbyte BuildPlayer { get; set; }
    }
}
