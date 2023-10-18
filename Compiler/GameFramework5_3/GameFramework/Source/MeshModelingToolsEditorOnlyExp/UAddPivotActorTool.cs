namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Given selected actors, creates an empty actor as the parent of those actors, at a location</summary>
[CppInclude("AddPivotActorTool.h")]
public partial class UAddPivotActorTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>TransformGizmo</summary>
	public UCombinedTransformGizmo TransformGizmo;
	///<summary>TransformProxy</summary>
	public UTransformProxy TransformProxy;
	///<summary>TransformProperties</summary>
	public UPivotActorTransformProperties TransformProperties;
}
