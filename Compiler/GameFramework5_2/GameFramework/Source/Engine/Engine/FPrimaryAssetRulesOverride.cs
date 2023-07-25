#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerSettings.h")]
///<summary>Simple structure to allow overriding asset rules for a specific primary asset. This can be used to set chunks</summary>
public partial struct FPrimaryAssetRulesOverride {
// PrimaryAssetRulesOverride
	public FPrimaryAssetId PrimaryAssetId;
	public FPrimaryAssetRules Rules;
}
