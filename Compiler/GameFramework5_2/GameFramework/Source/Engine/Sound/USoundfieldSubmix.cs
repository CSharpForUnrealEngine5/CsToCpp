#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundSubmix.h")]
///<summary>Sound Submix class meant for use with soundfield formats, such as Ambisonics.</summary>
public partial class USoundfieldSubmix : USoundSubmixWithParentBase {
// SoundfieldSubmix
	public string SoundfieldEncodingFormat;
	public USoundfieldEncodingSettingsBase EncodingSettings;
	public TArray<USoundfieldEffectBase> SoundfieldEffectChain;
	public UClass EncodingSettingsClass;
}
