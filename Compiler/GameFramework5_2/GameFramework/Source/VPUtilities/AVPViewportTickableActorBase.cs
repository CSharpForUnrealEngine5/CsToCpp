#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("VPViewportTickableActorBase.h")]
///<summary>Actor that tick in the Editor viewport with the event EditorTick.</summary>
public partial class AVPViewportTickableActorBase : AActor {
// VPViewportTickableActorBase
	public  void EditorTick(float DeltaSeconds) {}
	public  void EditorDestroyed() {}
	public  void EditorLockLocation(bool bSetLockLocation) {}
	public EVPViewportTickableFlags ViewportTickType;
}
