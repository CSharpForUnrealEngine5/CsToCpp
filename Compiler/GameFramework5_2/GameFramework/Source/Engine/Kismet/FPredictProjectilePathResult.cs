#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/GameplayStaticsTypes.h")]
///<summary>Container for the result of a projectile path trace (using PredictProjectilePath).</summary>
public partial struct FPredictProjectilePathResult {
// PredictProjectilePathResult
	public TArray<FPredictProjectilePathPointData> PathData;
	public FPredictProjectilePathPointData LastTraceDestination;
	public FHitResult HitResult;
}
