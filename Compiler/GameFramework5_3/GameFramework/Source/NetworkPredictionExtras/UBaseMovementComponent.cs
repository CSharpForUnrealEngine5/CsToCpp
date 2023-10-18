namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base component for movement. This essentially has the generic glue for selecting an UpdatedComponent and moving it along the world</summary>
[CppInclude("BaseMovementComponent.h")]
public partial class UBaseMovementComponent : UNetworkPredictionComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Callbacks</summary>
	public virtual void OnBeginOverlap(UPrimitiveComponent OverlappedComp,AActor Other,UPrimitiveComponent OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult SweepResult) {}
	///<summary>PhysicsVolumeChanged</summary>
	public virtual void PhysicsVolumeChanged(APhysicsVolume NewVolume) {}
	///<summary>UpdatedComponent</summary>
	public USceneComponent UpdatedComponent;
	///<summary>UpdatedPrimitive</summary>
	public UPrimitiveComponent UpdatedPrimitive;
}
