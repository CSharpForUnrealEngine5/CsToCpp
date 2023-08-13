namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the MVVM Editor</summary>
[CppInclude("MVVMDeveloperProjectSettings.h")]
public partial class UMVVMDeveloperProjectSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Permission list for filtering which properties are visible in UI.</summary>
	public TMap<FSoftClassPath,FMVVMDeveloperProjectWidgetSettings> FieldSelectorPermissions;
}
