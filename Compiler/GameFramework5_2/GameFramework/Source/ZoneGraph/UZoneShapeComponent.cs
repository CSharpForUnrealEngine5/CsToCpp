namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneShapeComponent.h")]
public partial class UZoneShapeComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>@return Shape type.</summary>
	public FZoneShapeType GetShapeType() { return default; }
	///<summary>Sets shape type.</summary>
	public void SetShapeType(FZoneShapeType Type) {}
	///<summary>@return Shape&#39;s tags.</summary>
	public FZoneGraphTagMask GetTags() { return default; }
	///<summary>Sets shape tags.</summary>
	public void SetTags(FZoneGraphTagMask NewTags) {}
	///<summary>@return True if common lane profile is reversed.</summary>
	public bool IsLaneProfileReversed() { return default; }
	///<summary>Set whether common lane profile should be reversed.</summary>
	public bool SetReverseLaneProfile(bool bReverse) { return default; }
	///<summary>Sets the polygon routing type.</summary>
	public void SetPolygonRoutingType(EZoneShapePolygonRoutingType NewType) {}
	///<summary>Common lane template for whole shape</summary>
	public FZoneLaneProfileRef LaneProfile;
	///<summary>True if lane profile should be reversed</summary>
	public bool bReverseLaneProfile;
	///<summary>Array of lane templates indexed by the points when the shape is polygon.</summary>
	public TArray<FZoneLaneProfileRef> PerPointLaneProfiles;
	///<summary>Shape points</summary>
	public TArray<FZoneShapePoint> Points;
	///<summary>Shape type, spline or polygon</summary>
	public FZoneShapeType ShapeType;
	///<summary>Polygon shape routing type</summary>
	public EZoneShapePolygonRoutingType PolygonRoutingType;
	///<summary>Zone tags, the lanes inherit zone tags.</summary>
	public FZoneGraphTagMask Tags;
	///<summary>Connectors for other shapes (not stored, these are refreshed from points).</summary>
	public TArray<FZoneShapeConnector> ShapeConnectors;
	///<summary>Array of connections matching ShapeConnectors (not stored, these are refreshed from connectors).</summary>
	public TArray<FZoneShapeConnection> ConnectedShapes;
}
