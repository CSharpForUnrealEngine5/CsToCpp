#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>TODO: We could replace *End with *Num, and use uint16. Begin probably needs to be int32/uint32</summary>
public partial struct FZoneLaneData {
// ZoneLaneData
	public float Width;
	public FZoneGraphTagMask Tags;
	public int PointsBegin;
	public int PointsEnd;
	public int LinksBegin;
	public int LinksEnd;
	public int ZoneIndex;
	public ushort StartEntryId;
	public ushort EndEntryId;
}
