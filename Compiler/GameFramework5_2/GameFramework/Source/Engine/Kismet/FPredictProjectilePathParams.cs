#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/GameplayStaticsTypes.h")]
///<summary>Input parameters to PredictProjectilePath functions.</summary>
public partial struct FPredictProjectilePathParams {
// PredictProjectilePathParams
	public FVector StartLocation;
	public FVector LaunchVelocity;
	public bool bTraceWithCollision;
	public float ProjectileRadius;
	public float MaxSimTime;
	public bool bTraceWithChannel;
	public byte TraceChannel;
	public TArray<byte> ObjectTypes;
	public TArray<AActor> ActorsToIgnore;
	public float SimFrequency;
	public float OverrideGravityZ;
	public byte DrawDebugType;
	public float DrawDebugTime;
	public bool bTraceComplex;
}
