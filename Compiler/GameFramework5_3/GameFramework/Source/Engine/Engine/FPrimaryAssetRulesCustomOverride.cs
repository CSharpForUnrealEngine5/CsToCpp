namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Apply primary asset rules to groups of primary assets, using type + filter directory or string</summary>
[CppInclude("Engine/AssetManagerSettings.h")]
public partial struct FPrimaryAssetRulesCustomOverride {
	public FPrimaryAssetType PrimaryAssetType;
	public FDirectoryPath FilterDirectory;
	public string FilterString;
	public FPrimaryAssetRules Rules;
}
