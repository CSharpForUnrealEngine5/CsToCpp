#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Properties of UI to adjust input meshes</summary>
[CppInclude("BaseTools/BaseCreateFromSelectedTool.h")]
public partial class UTransformInputsToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Show transform gizmo in the viewport to allow changing translation, rotation and scale of input meshes.</summary>
	public bool bShowTransformGizmo;
}
