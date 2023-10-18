namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("IVPInteraction.h")]
public partial class UVPInteraction : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Called when actor is dropped from Carry state by the VREd interactor</summary>
	public void OnActorDroppedFromCarry() {}
	///<summary>Called when an actor is selected by the VREd interactor</summary>
	public void OnActorSelectedForTransform() {}
	///<summary>Called when dropped by VRTool</summary>
	public void OnActorDroppedFromTransform() {}
}
