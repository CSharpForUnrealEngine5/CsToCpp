#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ViewportTransformer.h")]
public partial class UViewportTransformer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Init</summary>
	public  void Init(UViewportWorldInteraction InitViewportWorldInteraction) {}
	///<summary>Shutdown</summary>
	public  void Shutdown() {}
	///<summary>@return If this transformer can be used to align its transformable to actors in the scene</summary>
	public  bool CanAlignToActors() { return default; }
	///<summary>@return True if the transform gizmo should be aligned to the center of the bounds of all selected objects with more than one is selected.  Otherwise it will be at the pivot of the last transformable, similar to legacl editor actor selection</summary>
	public  bool ShouldCenterTransformGizmoPivot() { return default; }
	///<summary>When starting to drag</summary>
	public  void OnStartDragging(UViewportInteractor Interactor) {}
	///<summary>When ending drag</summary>
	public  void OnStopDragging(UViewportInteractor Interactor) {}
	///<summary>The viewport world interaction object we&#39;re registered with</summary>
	public UViewportWorldInteraction ViewportWorldInteraction;
}
