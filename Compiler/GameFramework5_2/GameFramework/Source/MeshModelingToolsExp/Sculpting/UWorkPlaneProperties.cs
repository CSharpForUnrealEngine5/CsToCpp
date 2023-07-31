#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sculpting/MeshSculptToolBase.h")]
public partial class UWorkPlaneProperties : UInteractiveToolPropertySet {
	///<summary>bPropertySetEnabled</summary>
	public bool bPropertySetEnabled;
	///<summary>Toggle whether Work Plane Positioning Gizmo is visible</summary>
	public bool bShowGizmo;
	///<summary>Position</summary>
	public FVector Position;
	///<summary>Rotation</summary>
	public FQuat Rotation;
}
