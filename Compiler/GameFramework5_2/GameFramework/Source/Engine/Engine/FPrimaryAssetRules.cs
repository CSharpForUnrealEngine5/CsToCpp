#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/AssetManagerTypes.h")]
///<summary>Structure defining rules for what to do with assets, this is defined per type and can be overridden per asset</summary>
public partial struct FPrimaryAssetRules {
// PrimaryAssetRules
	public int Priority;
	public int ChunkId;
	public bool bApplyRecursively;
	public EPrimaryAssetCookRule CookRule;
}
