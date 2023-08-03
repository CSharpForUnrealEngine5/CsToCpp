#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureEncodingSettings.h")]
public partial class UTextureEncodingUserSettings : UDeveloperSettings {
	public static UClass StaticClass() {return default;}
	///<summary>Local machine/project setting to force an encode speed, if desired.</summary>
	public ETextureEncodeSpeedOverride ForceEncodeSpeed;
}
