namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Event for indicating an area of disturbance.</summary>
[CppInclude("Annotations/ZoneGraphDisturbanceAnnotation.h")]
public partial struct FZoneGraphDisturbanceArea {
	public FVector Position;
	public float Radius;
	public float Duration;
	public uint InstigatorID;
}
