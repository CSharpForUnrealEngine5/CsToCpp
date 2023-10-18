namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LiveLinkSettings.h")]
public partial class ULiveLinkUserSettings : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The default location in which to save LiveLink presets</summary>
	public FDirectoryPath PresetSaveDir;
}
