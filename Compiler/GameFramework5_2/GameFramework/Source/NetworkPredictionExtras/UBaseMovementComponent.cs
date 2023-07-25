#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BaseMovementComponent.h")]
///<summary>Base component for movement. This essentially has the generic glue for selecting an UpdatedComponent and moving it along the world</summary>
public partial class UBaseMovementComponent : UNetworkPredictionComponent {
// BaseMovementComponent
	public void OnBeginOverlap(UObject OverlappedComp,UObject Other,UObject OtherComp,int OtherBodyIndex,bool bFromSweep,FHitResult SweepResult) {}
	public void PhysicsVolumeChanged(UObject NewVolume) {}
	public USceneComponent UpdatedComponent;
	public UPrimitiveComponent UpdatedPrimitive;
}
