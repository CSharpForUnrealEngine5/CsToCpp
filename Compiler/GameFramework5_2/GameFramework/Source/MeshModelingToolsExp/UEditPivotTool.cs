#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EditPivotTool.h")]
public partial class UEditPivotTool : UMultiSelectionMeshEditingTool {
// EditPivotTool
	public UEditPivotToolProperties TransformProps;
	public UEditPivotToolActionPropertySet EditPivotActions;
	public TArray<FEditPivotTarget> ActiveGizmos;
	public UDragAlignmentMechanic DragAlignmentMechanic;
}
