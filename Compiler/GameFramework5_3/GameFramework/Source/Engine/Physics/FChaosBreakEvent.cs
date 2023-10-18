namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/ChaosEventType.h")]
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
