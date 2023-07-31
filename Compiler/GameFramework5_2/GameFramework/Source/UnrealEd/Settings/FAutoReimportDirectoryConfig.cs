#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Auto reimport settings for a specific directory</summary>
[CppInclude("Settings/EditorLoadingSavingSettings.h")]
public partial struct FAutoReimportDirectoryConfig {
	public string SourceDirectory;
	public string MountPoint;
	public TArray<FAutoReimportWildcard> Wildcards;
}
