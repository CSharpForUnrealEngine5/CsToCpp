#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DrawAndRevolveTool.h")]
///<summary>Draws a profile curve and revolves it around an axis.</summary>
public partial class UDrawAndRevolveTool : UInteractiveTool {
// DrawAndRevolveTool
	public UCurveControlPointsMechanic ControlPointsMechanic;
	public UConstructionPlaneMechanic PlaneMechanic;
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public URevolveToolProperties Settings;
	public UNewMeshMaterialProperties MaterialProperties;
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
