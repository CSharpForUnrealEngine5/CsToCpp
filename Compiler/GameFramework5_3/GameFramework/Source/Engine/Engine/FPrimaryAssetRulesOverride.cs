namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple structure to allow overriding asset rules for a specific primary asset. This can be used to set chunks</summary>
[CppInclude("Engine/AssetManagerSettings.h")]
public partial struct FPrimaryAssetRulesOverride {
	public FPrimaryAssetId PrimaryAssetId;
	public FPrimaryAssetRules Rules;
}
