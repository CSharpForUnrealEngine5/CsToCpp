namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This opaque class should be used for specifying settings for how audio should be encoded</summary>
[CppInclude("ISoundfieldFormat.h")]
public partial class USoundfieldEffectBase : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>TODO: Filter classes settable on here by GetSettingsClass.</summary>
	public USoundfieldEffectSettingsBase Settings;
}
