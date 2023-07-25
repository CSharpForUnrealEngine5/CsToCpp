#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AI/Navigation/AvoidanceManager.h")]
public partial class UAvoidanceManager : UObject {
// AvoidanceManager
	public float DefaultTimeToLive;
	public float LockTimeAfterAvoid;
	public float LockTimeAfterClean;
	public float DeltaTimeToPredict;
	public float ArtificialRadiusExpansion;
	public float TestHeightDifference_DEPRECATED;
	public float HeightCheckMargin;
	public int GetObjectCount() { return default; }
	public int GetNewAvoidanceUID() { return default; }
	public bool RegisterMovementComponent(UObject MovementComp,float AvoidanceWeight/*=0.5f*/) { return default; }
	public FVector GetAvoidanceVelocityForComponent(UObject MovementComp) { return default; }
}
