namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/SearchProjectSettings.h")]
public partial class USearchProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>IgnoredPaths</summary>
	public TArray<FDirectoryPath> IgnoredPaths;
}
