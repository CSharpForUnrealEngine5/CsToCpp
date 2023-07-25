#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneGraphLaneRoutingRule {
// ZoneGraphLaneRoutingRule
	public bool bEnabled;
	public string Comment;
	public FZoneGraphTagFilter ZoneTagFilter;
	public FZoneLaneProfileRef SourceLaneProfile;
	public FZoneLaneProfileRef DestinationLaneProfile;
	public EZoneGraphLaneRoutingCountRule SourceOutgoingConnections;
	public EZoneGraphLaneRoutingCountRule DestinationIncomingConnections;
	public int ConnectionRestrictions;
}
