#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure defining rules for what to do with assets, this is defined per type and can be overridden per asset</summary>
[CppInclude("Engine/AssetManagerTypes.h")]
public partial struct FPrimaryAssetRules {
	public int Priority;
	public int ChunkId;
	public bool bApplyRecursively;
	public EPrimaryAssetCookRule CookRule;
}
