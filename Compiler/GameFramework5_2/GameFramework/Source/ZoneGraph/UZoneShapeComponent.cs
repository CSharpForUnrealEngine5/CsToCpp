#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneShapeComponent.h")]
public partial class UZoneShapeComponent : UPrimitiveComponent {
// ZoneShapeComponent
	public FZoneShapeType GetShapeType() { return default; }
	public void SetShapeType(FZoneShapeType Type) {}
	public FZoneGraphTagMask GetTags() { return default; }
	public void SetTags(FZoneGraphTagMask NewTags) {}
	public bool IsLaneProfileReversed() { return default; }
	public bool SetReverseLaneProfile(bool bReverse) { return default; }
	public void SetPolygonRoutingType(EZoneShapePolygonRoutingType NewType) {}
	public FZoneLaneProfileRef LaneProfile;
	public bool bReverseLaneProfile;
	public TArray<FZoneLaneProfileRef> PerPointLaneProfiles;
	public TArray<FZoneShapePoint> Points;
	public FZoneShapeType ShapeType;
	public EZoneShapePolygonRoutingType PolygonRoutingType;
	public FZoneGraphTagMask Tags;
	public TArray<FZoneShapeConnector> ShapeConnectors;
	public TArray<FZoneShapeConnection> ConnectedShapes;
}
