#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundNodeModPlayer.h")]
///<summary>Sound node that contains a reference to the mod file to be played</summary>
public partial class USoundNodeModPlayer : USoundNodeAssetReferencer {
// SoundNodeModPlayer
	public TSoftObjectPtr<USoundMod> SoundModAssetPtr;
	public USoundMod SoundMod;
	public bool bLooping;
}
