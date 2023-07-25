#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PatternTool.h")]
///<summary>UPatternTool takes input meshes and generates 3D Patterns of those meshes, by</summary>
public partial class UPatternTool : UMultiSelectionMeshEditingTool {
// PatternTool
	public UPatternToolSettings Settings;
	public UPatternTool_BoundingBoxSettings BoundingBoxSettings;
	public UPatternTool_LinearSettings LinearSettings;
	public UPatternTool_GridSettings GridSettings;
	public UPatternTool_RadialSettings RadialSettings;
	public UPatternTool_RotationSettings RotationSettings;
	public UPatternTool_TranslationSettings TranslationSettings;
	public UPatternTool_ScaleSettings ScaleSettings;
	public UPatternTool_OutputSettings OutputSettings;
	public UTransformProxy PatternGizmoProxy;
	public UCombinedTransformGizmo PatternGizmo;
	public UDragAlignmentMechanic DragAlignmentMechanic;
	public UConstructionPlaneMechanic PlaneMechanic;
	public TSet<UPrimitiveComponent> AllComponents;
	public UPreviewGeometry PreviewGeometry;
}
