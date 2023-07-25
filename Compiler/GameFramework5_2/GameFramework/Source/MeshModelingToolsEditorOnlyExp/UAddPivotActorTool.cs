#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AddPivotActorTool.h")]
///<summary>Given selected actors, creates an empty actor as the parent of those actors, at a location</summary>
public partial class UAddPivotActorTool : UMultiSelectionMeshEditingTool {
// AddPivotActorTool
	public UDragAlignmentMechanic DragAlignmentMechanic;
	public UCombinedTransformGizmo TransformGizmo;
	public UTransformProxy TransformProxy;
	public UPivotActorTransformProperties TransformProperties;
}
