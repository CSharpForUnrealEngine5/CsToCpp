namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Edit Pivot operation</summary>
[CppInclude("EditPivotTool.h")]
public partial class UEditPivotToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>When enabled, click-drag to reposition the Pivot</summary>
	public bool bEnableSnapDragging;
	///<summary>When Snap-Dragging, align source and target normals</summary>
	public EEditPivotSnapDragRotationMode RotationMode;
}
