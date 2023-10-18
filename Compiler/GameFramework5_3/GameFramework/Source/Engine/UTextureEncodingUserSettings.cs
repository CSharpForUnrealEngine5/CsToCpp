namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureEncodingSettingsPrivate.h")]
public partial class UTextureEncodingUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Local machine/project setting to force an encode speed, if desired.</summary>
	public ETextureEncodeSpeedOverride ForceEncodeSpeed;
}
