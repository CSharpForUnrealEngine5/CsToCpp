#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ISMEditorTool.h")]
///<summary>Standard properties of the Transform Meshes operation</summary>
public partial class UISMEditorToolProperties : UInteractiveToolPropertySet {
// ISMEditorToolProperties
	public EISMEditorTransformMode TransformMode;
	public bool bSetPivotMode;
	public bool bShowSelectable;
	public bool bShowSelected;
	public bool bHideWhenDragging;
	public TArray<string> SelectedInstances;
}
