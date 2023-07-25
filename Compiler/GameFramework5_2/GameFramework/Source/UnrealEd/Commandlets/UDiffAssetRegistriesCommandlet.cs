#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/DiffAssetRegistriesCommandlet.h")]
public partial class UDiffAssetRegistriesCommandlet : UCommandlet {
// DiffAssetRegistriesCommandlet
	public TArray<string> AssetRegistrySearchPath;
	public string P4Repository;
	public string P4EngineBasePath;
	public string P4EngineAssetPath;
	public string P4GameBasePath;
	public string P4GameAssetPath;
	public string RegexBranchCL;
}
