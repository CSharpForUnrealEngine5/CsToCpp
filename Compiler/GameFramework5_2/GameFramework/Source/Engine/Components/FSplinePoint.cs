namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Components/SplineComponent.h")]
public partial struct FSplinePoint {
	public float InputKey;
	public FVector Position;
	public FVector ArriveTangent;
	public FVector LeaveTangent;
	public FRotator Rotation;
	public FVector Scale;
	public ESplinePointType Type;
}
