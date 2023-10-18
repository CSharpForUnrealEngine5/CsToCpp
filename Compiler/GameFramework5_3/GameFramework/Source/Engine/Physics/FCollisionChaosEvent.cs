namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/ChaosEventType.h")]
public partial struct FCollisionChaosEvent {
	public FVector Location;
	public FVector AccumulatedImpulse;
	public FVector Normal;
	public float PenetrationDepth;
	public FCollisionChaosEventBodyInfo Body1;
	public FCollisionChaosEventBodyInfo Body2;
}
