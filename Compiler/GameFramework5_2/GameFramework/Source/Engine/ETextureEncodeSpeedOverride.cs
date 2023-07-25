#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("TextureEncodingSettings.h")]
///<summary>Enum that allows for not overriding what the existing setting is - all the</summary>
public enum ETextureEncodeSpeedOverride {
	Disabled=255,
	Final=0,
	FinalIfAvailable=1,
	Fast=2,
}
