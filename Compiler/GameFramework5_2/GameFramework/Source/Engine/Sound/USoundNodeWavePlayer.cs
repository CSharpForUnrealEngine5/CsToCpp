#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundNodeWavePlayer.h")]
///<summary>Sound node that contains a reference to the raw wave file to be played</summary>
public partial class USoundNodeWavePlayer : USoundNodeAssetReferencer {
// SoundNodeWavePlayer
	public TSoftObjectPtr<USoundWave> SoundWaveAssetPtr;
	public USoundWave SoundWave;
	public bool bLooping;
}
