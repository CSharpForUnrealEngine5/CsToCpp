namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OneSkyLocalizationServiceSettings.h")]
public partial class UOneSkyLocalizationTargetSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The array of settings for each target of this project</summary>
	public TArray<FOneSkyLocalizationTargetSetting> TargetSettings;
}
