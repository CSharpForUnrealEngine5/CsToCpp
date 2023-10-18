namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>@todo: BP2CPP_remove</summary>
[CppInclude("Engine/Blueprint.h")]
public partial struct FCompilerNativizationOptions {
	public FName PlatformName;
	public bool ServerOnlyPlatform;
	public bool ClientOnlyPlatform;
	public bool bExcludeMonolithicHeaders;
	public TArray<FName> ExcludedModules;
	public TSet<FSoftObjectPath> ExcludedAssets;
	public TArray<string> ExcludedFolderPaths;
}
