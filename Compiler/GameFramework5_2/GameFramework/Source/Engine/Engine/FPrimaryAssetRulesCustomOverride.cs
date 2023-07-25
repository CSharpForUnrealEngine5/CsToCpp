#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerSettings.h")]
///<summary>Apply primary asset rules to groups of primary assets, using type + filter directory or string</summary>
public partial struct FPrimaryAssetRulesCustomOverride {
// PrimaryAssetRulesCustomOverride
	public FPrimaryAssetType PrimaryAssetType;
	public FDirectoryPath FilterDirectory;
	public string FilterString;
	public FPrimaryAssetRules Rules;
}
