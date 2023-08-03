#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Standard properties of the Transform Meshes operation</summary>
[CppInclude("ISMEditorTool.h")]
public partial class UISMEditorToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Transformation Mode controls the overall behavior of the Gizmos in the Tool</summary>
	public EISMEditorTransformMode TransformMode;
	///<summary>When true, the Gizmo can be moved independently without affecting objects. This allows the Gizmo to be repositioned before transforming.</summary>
	public bool bSetPivotMode;
	///<summary>Show a highlight around all selectable instances</summary>
	public bool bShowSelectable;
	///<summary>Show a highlight around the selected instances</summary>
	public bool bShowSelected;
	///<summary>Hide the Selectable and Selected highlights when dragging with the Gizmos</summary>
	public bool bHideWhenDragging;
	///<summary>List of selected Component/Instance values</summary>
	public TArray<string> SelectedInstances;
}
