#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Shape connectors represent locations where shapes can be connected together.</summary>
public partial struct FZoneShapeConnector {
// ZoneShapeConnector
	public FVector Position;
	public FVector Normal;
	public FVector Up;
	public int PointIndex;
	public FZoneLaneProfileRef LaneProfile;
	public bool bReverseLaneProfile;
	public FZoneShapeType ShapeType;
}
