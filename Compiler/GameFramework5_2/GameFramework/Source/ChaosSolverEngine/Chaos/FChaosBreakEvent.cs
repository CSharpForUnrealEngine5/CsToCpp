#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
public partial struct FChaosBreakEvent {
	public UPrimitiveComponent Component;
	public FVector Location;
	public FVector Velocity;
	public FVector AngularVelocity;
	public FVector Extents;
	public float Mass;
	public int Index;
	public bool bFromCrumble;
}
