namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Input parameters to PredictProjectilePath functions.</summary>
[CppInclude("Kismet/GameplayStaticsTypes.h")]
public partial struct FPredictProjectilePathParams {
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
