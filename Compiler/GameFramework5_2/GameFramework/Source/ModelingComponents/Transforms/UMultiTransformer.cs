#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Transforms/MultiTransformer.h")]
///<summary>UMultiTransformer abstracts both a default TRS Gizmo, and the "Quick" translate/rotate Gizmos.</summary>
public partial class UMultiTransformer : UObject {
// MultiTransformer
	public UInteractiveGizmoManager GizmoManager;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
