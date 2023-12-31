namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event for indicating an obstacle.</summary>
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
public partial struct FZoneGraphObstacleDisturbanceArea {
	public FVector Position;
	public float Radius;
	public float ObstacleRadius;
	public EZoneGraphObstacleDisturbanceAreaAction Action;
}
