namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Container for the result of a projectile path trace (using PredictProjectilePath).</summary>
[CppInclude("Kismet/GameplayStaticsTypes.h")]
public partial struct FPredictProjectilePathResult {
	public TArray<FPredictProjectilePathPointData> PathData;
	public FPredictProjectilePathPointData LastTraceDestination;
	public FHitResult HitResult;
}
