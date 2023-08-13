namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Settings/ProjectPackagingSettings.h")]
///<summary>Enumerates the available methods for Blueprint nativization during project packaging.</summary>
public enum EProjectPackagingBlueprintNativizationMethod {
	Disabled=0,
	Inclusive=1,
	Exclusive=2,
}
