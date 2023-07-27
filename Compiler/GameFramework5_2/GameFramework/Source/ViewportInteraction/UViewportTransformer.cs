#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportTransformer.h")]
public partial class UViewportTransformer : UObject {
// ViewportTransformer
	public  void Init(UViewportWorldInteraction InitViewportWorldInteraction) {}
	public  void Shutdown() {}
	public  bool CanAlignToActors() { return default; }
	public  bool ShouldCenterTransformGizmoPivot() { return default; }
	public  void OnStartDragging(UViewportInteractor Interactor) {}
	public  void OnStopDragging(UViewportInteractor Interactor) {}
	public UViewportWorldInteraction ViewportWorldInteraction;
}
