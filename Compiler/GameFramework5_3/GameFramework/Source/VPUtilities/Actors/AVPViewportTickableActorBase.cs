namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Actor that tick in the Editor viewport with the event EditorTick.</summary>
[CppInclude("Actors/VPViewportTickableActorBase.h")]
public partial class AVPViewportTickableActorBase : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>EditorTick</summary>
	public void EditorTick(float DeltaSeconds) {}
	///<summary>EditorDestroyed</summary>
	public void EditorDestroyed() {}
	///<summary>Sets the LockLocation variable to disable movement from the translation gizmo</summary>
	public void EditorLockLocation(bool bSetLockLocation) {}
	///<summary>Where the actor should be ticked.</summary>
	public EVPViewportTickableFlags ViewportTickType;
}
