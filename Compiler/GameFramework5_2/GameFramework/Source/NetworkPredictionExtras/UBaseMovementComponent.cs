#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base component for movement. This essentially has the generic glue for selecting an UpdatedComponent and moving it along the world</summary>
[CppInclude("BaseMovementComponent.h")]
public partial class UBaseMovementComponent : UNetworkPredictionComponent {
	///<summary>Callbacks</summary>
	public  void OnBeginOverlap(UPrimitiveComponent OverlappedComp,AActor Other,UPrimitiveComponent OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult SweepResult) {}
	///<summary>PhysicsVolumeChanged</summary>
	public  void PhysicsVolumeChanged(APhysicsVolume NewVolume) {}
	///<summary>UpdatedComponent</summary>
	public USceneComponent UpdatedComponent;
	///<summary>UpdatedPrimitive</summary>
	public UPrimitiveComponent UpdatedPrimitive;
}
