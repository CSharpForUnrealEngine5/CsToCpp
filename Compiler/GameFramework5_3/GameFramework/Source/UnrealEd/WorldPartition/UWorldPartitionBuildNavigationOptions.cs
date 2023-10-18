namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("WorldPartition/WorldPartitionBuildNavigationOptions.h")]
public partial class UWorldPartitionBuildNavigationOptions : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Use verbose logging.</summary>
	public bool bVerbose;
	///<summary>When enabled, delete all NavigationDataChunkActors instead of generating them.</summary>
	public bool bCleanPackages;
}
