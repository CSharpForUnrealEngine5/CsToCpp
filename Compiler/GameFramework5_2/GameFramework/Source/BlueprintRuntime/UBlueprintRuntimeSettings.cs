namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for the BlueprintRuntime module</summary>
[CppInclude("BlueprintRuntimeSettings.h")]
public partial class UBlueprintRuntimeSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WarningSettings</summary>
	public TArray<FBlueprintWarningSettings> WarningSettings;
}
