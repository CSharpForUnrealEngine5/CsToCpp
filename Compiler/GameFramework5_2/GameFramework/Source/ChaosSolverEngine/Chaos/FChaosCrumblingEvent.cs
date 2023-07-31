#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Chaos/ChaosGameplayEventDispatcher.h")]
public partial struct FChaosCrumblingEvent {
	public UPrimitiveComponent Component;
	public FVector Location;
	public FQuat Orientation;
	public FVector LinearVelocity;
	public FVector AngularVelocity;
	public float Mass;
	public FBox LocalBounds;
	public TArray<int> Children;
}
