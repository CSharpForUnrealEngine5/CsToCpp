#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("RevolveBoundaryTool.h")]
///<summary>Tool that revolves the boundary of a mesh around an axis to create a new mesh. Mainly useful for</summary>
public partial class URevolveBoundaryTool : UMeshBoundaryToolBase {
// RevolveBoundaryTool
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	public URevolveBoundaryToolProperties Settings;
	public UNewMeshMaterialProperties MaterialProperties;
	public UConstructionPlaneMechanic PlaneMechanic;
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
