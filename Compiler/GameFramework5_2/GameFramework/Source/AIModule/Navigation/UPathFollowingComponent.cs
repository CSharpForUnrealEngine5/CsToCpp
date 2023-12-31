namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Navigation/PathFollowingComponent.h")]
public partial class UPathFollowingComponent : UActorComponent {
	public static UClass StaticClass() {return default;}
	///<summary>called when moving agent collides with another actor</summary>
	public virtual void OnActorBump(AActor SelfActor,AActor OtherActor,FVector NormalImpulse,FHitResult Hit) {}
	///<summary>GetPathActionType</summary>
	public EPathFollowingAction GetPathActionType() { return default; }
	///<summary>GetPathDestination</summary>
	public FVector GetPathDestination() { return default; }
	///<summary>associated movement component</summary>
	public UNavMovementComponent MovementComp;
	///<summary>navigation data for agent described in movement component</summary>
	public ANavigationData MyNavData;
	///<summary>called when NavigationSystem registers new navigation data type while this component</summary>
	public void OnNavDataRegistered(ANavigationData NavData) {}
}
