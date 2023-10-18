namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/ChaosEventType.h")]
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
