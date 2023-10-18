namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UPatternTool takes input meshes and generates 3D Patterns of those meshes, by</summary>
[CppInclude("PatternTool.h")]
public partial class UPatternTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UPatternToolSettings Settings;
	///<summary>BoundingBoxSettings</summary>
	public UPatternTool_BoundingBoxSettings BoundingBoxSettings;
	///<summary>LinearSettings</summary>
	public UPatternTool_LinearSettings LinearSettings;
	///<summary>GridSettings</summary>
	public UPatternTool_GridSettings GridSettings;
	///<summary>RadialSettings</summary>
	public UPatternTool_RadialSettings RadialSettings;
	///<summary>RotationSettings</summary>
	public UPatternTool_RotationSettings RotationSettings;
	///<summary>TranslationSettings</summary>
	public UPatternTool_TranslationSettings TranslationSettings;
	///<summary>ScaleSettings</summary>
	public UPatternTool_ScaleSettings ScaleSettings;
	///<summary>OutputSettings</summary>
	public UPatternTool_OutputSettings OutputSettings;
	///<summary>PatternGizmoProxy</summary>
	public UTransformProxy PatternGizmoProxy;
	///<summary>PatternGizmo</summary>
	public UCombinedTransformGizmo PatternGizmo;
	///<summary>DragAlignmentMechanic</summary>
	public UDragAlignmentMechanic DragAlignmentMechanic;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>AllComponents</summary>
	public TSet<UPrimitiveComponent> AllComponents;
	///<summary>PreviewGeometry</summary>
	public UPreviewGeometry PreviewGeometry;
}
