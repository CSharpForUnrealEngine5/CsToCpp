#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ZoneGraphTypes.h")]
public partial struct FZoneShapePoint {
	public FVector Position;
	public FVector InControlPoint_DEPRECATED;
	public FVector OutControlPoint_DEPRECATED;
	public float TangentLength;
	public float InnerTurnRadius;
	public FRotator Rotation;
	public FZoneShapePointType Type;
	public byte LaneProfile;
	public bool bReverseLaneProfile;
	public int LaneConnectionRestrictions;
}
