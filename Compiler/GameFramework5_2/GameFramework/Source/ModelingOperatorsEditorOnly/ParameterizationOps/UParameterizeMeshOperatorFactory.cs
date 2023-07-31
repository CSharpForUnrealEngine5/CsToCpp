#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Can be hooked up to a UMeshOpPreviewWithBackgroundCompute to perform UV parameterization operations.</summary>
[CppInclude("ParameterizationOps/ParameterizeMeshOp.h")]
public partial class UParameterizeMeshOperatorFactory : UObject {
	///<summary>Settings</summary>
	public UParameterizeMeshToolProperties Settings;
	///<summary>UVAtlasProperties</summary>
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	///<summary>XAtlasProperties</summary>
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	///<summary>PatchBuilderProperties</summary>
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
}
