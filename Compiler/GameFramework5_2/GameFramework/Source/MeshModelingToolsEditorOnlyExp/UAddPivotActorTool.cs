#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given selected actors, creates an empty actor as the parent of those actors, at a location</summary>
[CppInclude("AddPivotActorTool.h")]
public partial class UAddPivotActorTool : UMultiSelectionMeshEditingTool {
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformProperties</summary>
	public UPivotActorTransformProperties TransformProperties;
}
