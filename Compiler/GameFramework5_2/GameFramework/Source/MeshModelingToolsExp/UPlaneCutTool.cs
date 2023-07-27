#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PlaneCutTool.h")]
///<summary>Simple Mesh Plane Cutting Tool</summary>
public partial class UPlaneCutTool : UMultiSelectionMeshEditingTool {
// PlaneCutTool
	public UPlaneCutToolProperties BasicProperties;
	public UAcceptOutputProperties AcceptProperties;
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	public  void Cut() {}
	public  void FlipPlane() {}
	public TArray<UDynamicMeshReplacementChangeTarget> MeshesToCut;
	public UConstructionPlaneMechanic PlaneMechanic;
}
