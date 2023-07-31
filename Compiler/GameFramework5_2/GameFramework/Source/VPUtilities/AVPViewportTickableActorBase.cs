#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that tick in the Editor viewport with the event EditorTick.</summary>
[CppInclude("VPViewportTickableActorBase.h")]
public partial class AVPViewportTickableActorBase : AActor {
	///<summary>EditorTick</summary>
	public  void EditorTick(float DeltaSeconds) {}
	///<summary>EditorDestroyed</summary>
	public  void EditorDestroyed() {}
	///<summary>Sets the LockLocation variable to disable movement from the translation gizmo</summary>
	public  void EditorLockLocation(bool bSetLockLocation) {}
	///<summary>Where the actor should be ticked.</summary>
	public EVPViewportTickableFlags ViewportTickType;
}
