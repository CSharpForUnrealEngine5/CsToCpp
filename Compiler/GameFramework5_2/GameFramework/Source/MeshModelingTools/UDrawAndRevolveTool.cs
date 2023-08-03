#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Draws a profile curve and revolves it around an axis.</summary>
[CppInclude("DrawAndRevolveTool.h")]
public partial class UDrawAndRevolveTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>ControlPointsMechanic</summary>
	public UCurveControlPointsMechanic ControlPointsMechanic;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Settings</summary>
	public URevolveToolProperties Settings;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
