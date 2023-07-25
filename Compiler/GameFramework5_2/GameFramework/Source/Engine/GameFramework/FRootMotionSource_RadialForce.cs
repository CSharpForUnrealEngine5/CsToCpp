#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GameFramework/RootMotionSource.h")]
///<summary>RadialForce applies a force pulling or pushing away from a given world location to the target</summary>
public partial struct FRootMotionSource_RadialForce {
// RootMotionSource_RadialForce
	public FVector Location;
	public AActor LocationActor;
	public float Radius;
	public float Strength;
	public bool bIsPush;
	public bool bNoZForce;
	public UCurveFloat StrengthDistanceFalloff;
	public UCurveFloat StrengthOverTime;
	public bool bUseFixedWorldDirection;
	public FRotator FixedWorldDirection;
}
