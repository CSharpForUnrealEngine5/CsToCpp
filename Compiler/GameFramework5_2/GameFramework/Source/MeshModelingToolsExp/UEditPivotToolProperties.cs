#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Edit Pivot operation</summary>
[CppInclude("EditPivotTool.h")]
public partial class UEditPivotToolProperties : UInteractiveToolPropertySet {
	///<summary>When enabled, click-drag to reposition the Pivot</summary>
	public bool bEnableSnapDragging;
	///<summary>When Snap-Dragging, align source and target normals</summary>
	public EEditPivotSnapDragRotationMode RotationMode;
}
