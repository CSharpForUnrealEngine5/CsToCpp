#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple Mesh Plane Cutting Tool</summary>
[CppInclude("PlaneCutTool.h")]
public partial class UPlaneCutTool : UMultiSelectionMeshEditingTool {
	public static UClass StaticClass() {return default;}
	///<summary>BasicProperties</summary>
	public UPlaneCutToolProperties BasicProperties;
	///<summary>AcceptProperties</summary>
	public UAcceptOutputProperties AcceptProperties;
	///<summary>Previews</summary>
	public TArray<UMeshOpPreviewWithBackgroundCompute> Previews;
	///<summary>Cut with the current plane without exiting the tool (Hotkey: T)</summary>
	public  void Cut() {}
	///<summary>Flip the cutting plane (Hotkey: R)</summary>
	public  void FlipPlane() {}
	///<summary>MeshesToCut</summary>
	public TArray<UDynamicMeshReplacementChangeTarget> MeshesToCut;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
}
