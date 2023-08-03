#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Tool that revolves the boundary of a mesh around an axis to create a new mesh. Mainly useful for</summary>
[CppInclude("RevolveBoundaryTool.h")]
public partial class URevolveBoundaryTool : UMeshBoundaryToolBase {
	public static UClass StaticClass() {return default;}
	///<summary>Property set for type of output object (StaticMesh, Volume, etc)</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>Settings</summary>
	public URevolveBoundaryToolProperties Settings;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
}
