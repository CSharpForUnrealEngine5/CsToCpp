#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/EditorLoadingSavingSettings.h")]
///<summary>Auto reimport settings for a specific directory</summary>
public partial struct FAutoReimportDirectoryConfig {
// AutoReimportDirectoryConfig
	public string SourceDirectory;
	public string MountPoint;
	public TArray<FAutoReimportWildcard> Wildcards;
}
