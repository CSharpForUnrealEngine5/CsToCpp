namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>TODO: We could replace *End with *Num, and use uint16. Begin probably needs to be int32/uint32</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneLaneData {
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
