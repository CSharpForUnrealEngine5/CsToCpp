#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@todo: BP2CPP_remove</summary>
[CppInclude("Engine/Blueprint.h")]
public partial struct FCompilerNativizationOptions {
	public string PlatformName;
	public bool ServerOnlyPlatform;
	public bool ClientOnlyPlatform;
	public bool bExcludeMonolithicHeaders;
	public TArray<string> ExcludedModules;
	public TSet<FSoftObjectPath> ExcludedAssets;
	public TArray<string> ExcludedFolderPaths;
}
