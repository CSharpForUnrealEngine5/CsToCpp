namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data about a single point in a projectile path trace.</summary>
[CppInclude("Kismet/GameplayStaticsTypes.h")]
public partial struct FPredictProjectilePathPointData {
	public FVector Location;
	public FVector Velocity;
	public float Time;
}
