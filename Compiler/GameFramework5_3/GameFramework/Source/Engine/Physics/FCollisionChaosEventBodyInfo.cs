namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Physics/Experimental/ChaosEventType.h")]
public partial struct FCollisionChaosEventBodyInfo {
	public FVector Velocity;
	public FVector DeltaVelocity;
	public FVector AngularVelocity;
	public float Mass;
	public UPhysicalMaterial PhysMaterial;
	public TWeakObjectPtr<UPrimitiveComponent> Component;
	public int BodyIndex;
	public FName BoneName;
}
