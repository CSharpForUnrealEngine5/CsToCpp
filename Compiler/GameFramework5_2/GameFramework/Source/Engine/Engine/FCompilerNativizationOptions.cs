#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/Blueprint.h")]
///<summary>@todo: BP2CPP_remove</summary>
public partial struct FCompilerNativizationOptions {
// CompilerNativizationOptions
	public string PlatformName;
	public bool ServerOnlyPlatform;
	public bool ClientOnlyPlatform;
	public bool bExcludeMonolithicHeaders;
	public TArray<string> ExcludedModules;
	public TSet<FSoftObjectPath> ExcludedAssets;
	public TArray<string> ExcludedFolderPaths;
}
