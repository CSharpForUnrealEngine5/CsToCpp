namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ProjectPackagingSettings.h")]
///<summary>The list of possible registry writebacks. During staging, iostore can</summary>
public enum EAssetRegistryWritebackMethod {
	Disabled=0,
	OriginalFile=1,
	AdjacentFile=2,
}
