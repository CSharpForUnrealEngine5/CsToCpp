namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound Submix class meant for use with soundfield formats, such as Ambisonics.</summary>
[CppInclude("Sound/SoundSubmix.h")]
public partial class USoundfieldSubmix : USoundSubmixWithParentBase {
	public static UClass StaticClass() {return default;}
	///<summary>Currently used format.</summary>
	public FName SoundfieldEncodingFormat;
	///<summary>Which encoding settings to use the sound field.</summary>
	public USoundfieldEncodingSettingsBase EncodingSettings;
	///<summary>Soundfield effect chain to use for the sound field.</summary>
	public TArray<USoundfieldEffectBase> SoundfieldEffectChain;
	///<summary>EncodingSettingsClass</summary>
	public UClass EncodingSettingsClass;
}
