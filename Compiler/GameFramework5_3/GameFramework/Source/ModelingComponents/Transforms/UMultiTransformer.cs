namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UMultiTransformer abstracts both a default TRS Gizmo, and the &quot;Quick&quot; translate/rotate Gizmos.</summary>
[CppInclude("Transforms/MultiTransformer.h")]
public partial class UMultiTransformer : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GizmoManager</summary>
	public UInteractiveGizmoManager GizmoManager;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>We have to hold on to the mechanic only because the MultiTransformer has the capacity to delete and</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
