#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ITF/TransformInteraction.h")]
///<summary>UXRCreativeTransformInteraction manages a 3D Translate/Rotate/Scale (TRS) Gizmo.</summary>
public partial class UXRCreativeTransformInteraction : UObject {
// XRCreativeTransformInteraction
	public  void SetEnableScaling(bool bEnable) {}
	public  void SetEnableNonUniformScaling(bool bEnable) {}
	public  void ForceUpdateGizmoState() {}
	public UTransformProxy TransformProxy;
	public UCombinedTransformGizmo TransformGizmo;
}
