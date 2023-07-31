#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the MVVM Editor</summary>
[CppInclude("MVVMDeveloperProjectSettings.h")]
public partial class UMVVMDeveloperProjectSettings : UDeveloperSettings {
	///<summary>Permission list for filtering which properties are visible in UI.</summary>
	public TMap<FSoftClassPath,FMVVMDeveloperProjectWidgetSettings> FieldSelectorPermissions;
}
