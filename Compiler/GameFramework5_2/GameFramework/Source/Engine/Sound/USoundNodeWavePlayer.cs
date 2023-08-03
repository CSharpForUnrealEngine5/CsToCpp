#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound node that contains a reference to the raw wave file to be played</summary>
[CppInclude("Sound/SoundNodeWavePlayer.h")]
public partial class USoundNodeWavePlayer : USoundNodeAssetReferencer {
	public static UClass StaticClass() {return default;}
	///<summary>SoundWaveAssetPtr</summary>
	public TSoftObjectPtr<USoundWave> SoundWaveAssetPtr;
	///<summary>SoundWave</summary>
	public USoundWave SoundWave;
	///<summary>bLooping</summary>
	public bool bLooping;
}
