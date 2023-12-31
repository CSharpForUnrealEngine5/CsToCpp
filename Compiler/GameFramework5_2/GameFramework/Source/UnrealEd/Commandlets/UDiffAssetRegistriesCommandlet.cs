namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Commandlets/DiffAssetRegistriesCommandlet.h")]
public partial class UDiffAssetRegistriesCommandlet : UCommandlet {
	public static UClass StaticClass() {return default;}
	///<summary>AssetRegistrySearchPath</summary>
	public TArray<string> AssetRegistrySearchPath;
	///<summary>P4Repository</summary>
	public string P4Repository;
	///<summary>P4EngineBasePath</summary>
	public string P4EngineBasePath;
	///<summary>P4EngineAssetPath</summary>
	public string P4EngineAssetPath;
	///<summary>P4GameBasePath</summary>
	public string P4GameBasePath;
	///<summary>P4GameAssetPath</summary>
	public string P4GameAssetPath;
	///<summary>RegexBranchCL</summary>
	public string RegexBranchCL;
}
