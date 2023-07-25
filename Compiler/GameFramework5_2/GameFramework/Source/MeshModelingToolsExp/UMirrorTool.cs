#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MirrorTool.h")]
///<summary>Tool for mirroring one or more meshes across a plane.</summary>
public partial class UMirrorTool : UMultiSelectionMeshEditingTool {
// MirrorTool
	public UMirrorToolProperties Settings;
	public UMirrorToolActionPropertySet ToolActions;
	public TArray<UDynamicMeshReplacementChangeTarget> MeshesToMirror;
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	public UConstructionPlaneMechanic PlaneMechanic;
}
