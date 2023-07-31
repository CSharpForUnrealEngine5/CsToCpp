#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
public partial class UMeshSymmetryProperties : UInteractiveToolPropertySet {
	///<summary>Enable/Disable symmetric sculpting. This option will not be available if symmetry cannot be detected, or a non-symmetric edit has been made</summary>
	public bool bEnableSymmetry;
	///<summary>this flag is set/updated by the Tool to enable/disable the bEnableSymmetry toggle</summary>
	public bool bSymmetryCanBeEnabled;
}
