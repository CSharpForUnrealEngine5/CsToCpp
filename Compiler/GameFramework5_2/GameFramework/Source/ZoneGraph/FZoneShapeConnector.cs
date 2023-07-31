#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Shape connectors represent locations where shapes can be connected together.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneShapeConnector {
	public FVector Position;
	public FVector Normal;
	public FVector Up;
	public int PointIndex;
	public FZoneLaneProfileRef LaneProfile;
	public bool bReverseLaneProfile;
	public FZoneShapeType ShapeType;
}
