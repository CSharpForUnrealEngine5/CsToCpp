#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
public partial struct FSplinePoint {
// SplinePoint
	public float InputKey;
	public FVector Position;
	public FVector ArriveTangent;
	public FVector LeaveTangent;
	public FRotator Rotation;
	public FVector Scale;
	public byte Type;
}
