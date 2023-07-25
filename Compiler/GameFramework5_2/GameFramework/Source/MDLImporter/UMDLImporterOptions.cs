#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MDLImporterOptions.h")]
public partial class UMDLImporterOptions : UObject {
// MDLImporterOptions
	public uint BakingResolution;
	public uint BakingSamples;
	public FDirectoryPath ResourcesDir;
	public FDirectoryPath ModulesDir;
	public float MetersPerSceneUnit;
	public bool bForceBaking;
}
