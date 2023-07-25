#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Linked lane, used for query results. See also: FZoneLaneLinkData</summary>
public partial struct FZoneGraphLinkedLane {
// ZoneGraphLinkedLane
	public FZoneGraphLaneHandle DestLane;
	public EZoneLaneLinkType Type;
	public byte Flags;
}
