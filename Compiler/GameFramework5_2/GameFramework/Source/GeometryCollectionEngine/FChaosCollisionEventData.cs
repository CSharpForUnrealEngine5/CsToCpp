#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosCollisionEventFilter.h")]
///<summary>A collision event data structure</summary>
public partial struct FChaosCollisionEventData {
// ChaosCollisionEventData
	public FVector Location;
	public FVector Normal;
	public FVector Velocity1;
	public FVector Velocity2;
	public float Mass1;
	public float Mass2;
	public FVector Impulse;
}
