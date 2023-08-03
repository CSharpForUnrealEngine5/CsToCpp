#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("FractureToolPlaneCut.h")]
public partial class UFractureToolPlaneCut : UFractureToolCutterBase {
	public static UClass StaticClass() {return default;}
	///<summary>Slicing</summary>
	public UFracturePlaneCutSettings PlaneCutSettings;
	///<summary>GizmoSettings</summary>
	public UFractureTransformGizmoSettings GizmoSettings;
	///<summary>NoisePreview</summary>
	public UMeshOpPreviewWithBackgroundCompute NoisePreview;
}
