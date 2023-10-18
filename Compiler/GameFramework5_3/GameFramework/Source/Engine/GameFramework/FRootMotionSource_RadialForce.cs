namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>RadialForce applies a force pulling or pushing away from a given world location to the target</summary>
[CppInclude("GameFramework/RootMotionSource.h")]
public partial struct FRootMotionSource_RadialForce {
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
