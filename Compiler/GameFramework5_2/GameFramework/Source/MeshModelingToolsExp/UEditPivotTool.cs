namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditPivotTool.h")]
public partial class UEditPivotTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>TransformProps</summary>
	public UEditPivotToolProperties TransformProps;
	///<summary>EditPivotActions</summary>
	public UEditPivotToolActionPropertySet EditPivotActions;
	///<summary>ActiveGizmos</summary>
	public TArray<FEditPivotTarget> ActiveGizmos;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
