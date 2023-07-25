#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
///<summary>Event for indicating an area of disturbance.</summary>
public partial struct FZoneGraphDisturbanceArea {
// ZoneGraphDisturbanceArea
	public FVector Position;
	public float Radius;
	public float Duration;
	public uint InstigatorID;
}
