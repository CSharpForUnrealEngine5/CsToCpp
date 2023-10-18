namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Connection between two shape connectors.</summary>
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneShapeConnection {
	public TWeakObjectPtr<UZoneShapeComponent> ShapeComponent;
	public int ConnectorIndex;
}
