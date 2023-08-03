#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool for mirroring one or more meshes across a plane.</summary>
[CppInclude("MirrorTool.h")]
public partial class UMirrorTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public UMirrorToolProperties Settings;
	///<summary>ToolActions</summary>
	public UMirrorToolActionPropertySet ToolActions;
	///<summary>MeshesToMirror</summary>
	public TArray<UDynamicMeshReplacementChangeTarget> MeshesToMirror;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
}
