#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportTransformer.h")]
public partial class UViewportTransformer : UObject {
// ViewportTransformer
	public void Init(UObject InitViewportWorldInteraction) {}
	public void Shutdown() {}
	public bool CanAlignToActors() { return default; }
	public bool ShouldCenterTransformGizmoPivot() { return default; }
	public void OnStartDragging(UObject Interactor) {}
	public void OnStopDragging(UObject Interactor) {}
	public UViewportWorldInteraction ViewportWorldInteraction;
}
