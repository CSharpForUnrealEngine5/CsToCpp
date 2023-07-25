#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioMixerBlueprintLibrary.h")]
///<summary>Duplicate of Audio::EAudioMixerStreamDataFormat::Type, to get around UHT's lack of namespace support</summary>
public enum EAudioMixerStreamDataFormatType {
	Unknown=0,
	Float=1,
	Int16=2,
	Unsupported=3,
}
