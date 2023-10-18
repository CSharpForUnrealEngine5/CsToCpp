namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>List of settings associated to level viewport instances linked with an identifier</summary>
[CppInclude("OpenColorIOEditorSettings.h")]
public partial class UOpenColorIOLevelViewportSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Settings associated to each viewport that was configured</summary>
	public TArray<FPerViewportDisplaySettingPair> ViewportsSettings;
}
