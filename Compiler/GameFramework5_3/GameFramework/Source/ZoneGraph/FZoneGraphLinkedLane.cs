namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Linked lane, used for query results. See also: FZoneLaneLinkData</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphLinkedLane {
	public FZoneGraphLaneHandle DestLane;
	public EZoneLaneLinkType Type;
	public byte Flags;
}
