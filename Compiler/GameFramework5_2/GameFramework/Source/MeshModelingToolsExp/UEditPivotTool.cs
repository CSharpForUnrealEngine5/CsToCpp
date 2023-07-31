#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditPivotTool.h")]
public partial class UEditPivotTool : UMultiSelectionMeshEditingTool {
	///<summary>TransformProps</summary>
	public UEditPivotToolProperties TransformProps;
	///<summary>EditPivotActions</summary>
	public UEditPivotToolActionPropertySet EditPivotActions;
	///<summary>ActiveGizmos</summary>
	public TArray<FEditPivotTarget> ActiveGizmos;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
