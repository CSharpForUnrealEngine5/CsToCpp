namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct describing a link for a specified lane, used during building</summary>
[CppInclude("ZoneShapeUtilities.h")]
public partial struct FZoneShapeLaneInternalLink {
	public int LaneIndex;
	public FZoneLaneLinkData LinkData;
}
