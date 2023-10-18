namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Revolves a selected spline to create a new mesh.</summary>
[CppInclude("RevolveSplineTool.h")]
public partial class URevolveSplineTool : UInteractiveTool {
	public static UClass StaticClass() {return default;}
	///<summary>Settings</summary>
	public URevolveSplineToolProperties Settings;
	///<summary>MaterialProperties</summary>
	public UNewMeshMaterialProperties MaterialProperties;
	///<summary>OutputTypeProperties</summary>
	public UCreateMeshObjectTypeProperties OutputTypeProperties;
	///<summary>ToolActions</summary>
	public URevolveSplineToolActionPropertySet ToolActions;
	///<summary>Preview</summary>
	public UMeshOpPreviewWithBackgroundCompute Preview;
	///<summary>PlaneMechanic</summary>
	public UConstructionPlaneMechanic PlaneMechanic;
}
