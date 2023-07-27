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
	public ECollisionChannel TraceChannel;
	public TArray<EObjectTypeQuery> ObjectTypes;
	public TArray<AActor> ActorsToIgnore;
	public float SimFrequency;
	public float OverrideGravityZ;
	public EDrawDebugTrace DrawDebugType;
	public float DrawDebugTime;
	public bool bTraceComplex;
}
