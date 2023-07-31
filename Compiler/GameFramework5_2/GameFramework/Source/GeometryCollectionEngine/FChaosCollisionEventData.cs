#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A collision event data structure</summary>
[CppInclude("ChaosCollisionEventFilter.h")]
public partial struct FChaosCollisionEventData {
	public FVector Location;
	public FVector Normal;
	public FVector Velocity1;
	public FVector Velocity2;
	public float Mass1;
	public float Mass2;
	public FVector Impulse;
}
