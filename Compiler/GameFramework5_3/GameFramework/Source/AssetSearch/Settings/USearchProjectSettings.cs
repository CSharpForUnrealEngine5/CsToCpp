namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SearchProjectSettings.h")]
public partial class USearchProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>IntermediateStorage</summary>
	public ESearchIntermediateStorage IntermediateStorage;
	///<summary>IgnoredPaths</summary>
	public TArray<FDirectoryPath> IgnoredPaths;
}
