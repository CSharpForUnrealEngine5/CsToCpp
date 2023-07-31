#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UXRCreativeTransformInteraction manages a 3D Translate/Rotate/Scale (TRS) Gizmo.</summary>
[CppInclude("ITF/TransformInteraction.h")]
public partial class UXRCreativeTransformInteraction : UObject {
	///<summary>SetEnableScaling</summary>
	public  void SetEnableScaling(bool bEnable) {}
	///<summary>SetEnableNonUniformScaling</summary>
	public  void SetEnableNonUniformScaling(bool bEnable) {}
	///<summary>Recreate Gizmo. Call when external state changes, like set of selected objects</summary>
	public  void ForceUpdateGizmoState() {}
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
}
