#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ParameterizationOps/ParameterizeMeshOp.h")]
///<summary>Can be hooked up to a UMeshOpPreviewWithBackgroundCompute to perform UV parameterization operations.</summary>
public partial class UParameterizeMeshOperatorFactory : UObject {
// ParameterizeMeshOperatorFactory
	public UParameterizeMeshToolProperties Settings;
	public UParameterizeMeshToolUVAtlasProperties UVAtlasProperties;
	public UParameterizeMeshToolXAtlasProperties XAtlasProperties;
	public UParameterizeMeshToolPatchBuilderProperties PatchBuilderProperties;
}
