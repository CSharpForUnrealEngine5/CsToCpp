namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundWave.h")]
///<summary>Sound Asset Compression Type</summary>
public enum ESoundAssetCompressionType {
	BinkAudio=0,
	ADPCM=1,
	PCM=2,
	PlatformSpecific=3,
	ProjectDefined=4,
}
