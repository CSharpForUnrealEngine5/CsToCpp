#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
///<summary>Connection between two shape connectors.</summary>
public partial struct FZoneShapeConnection {
// ZoneShapeConnection
	public TWeakObjectPtr<UZoneShapeComponent> ShapeComponent;
	public int ConnectorIndex;
}
