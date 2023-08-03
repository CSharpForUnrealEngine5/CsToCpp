#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DynamicMeshSculptTool.h")]
public partial class UFixedPlaneBrushProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>bPropertySetEnabled</summary>
	public bool bPropertySetEnabled;
	///<summary>Toggle whether Work Plane Positioning Gizmo is visible</summary>
	public bool bShowGizmo;
	///<summary>Position</summary>
	public FVector Position;
	///<summary>Rotation</summary>
	public FQuat Rotation;
}
