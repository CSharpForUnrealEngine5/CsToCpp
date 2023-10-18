namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshVertexSculptTool.h")]
public partial class UMeshSymmetryProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Enable/Disable symmetric sculpting. This option will not be available if symmetry cannot be detected, or a non-symmetric edit has been made</summary>
	public bool bEnableSymmetry;
	///<summary>this flag is set/updated by the Tool to enable/disable the bEnableSymmetry toggle</summary>
	public bool bSymmetryCanBeEnabled;
}
