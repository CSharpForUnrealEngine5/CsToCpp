#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Sound node that contains a reference to the mod file to be played</summary>
[CppInclude("SoundNodeModPlayer.h")]
public partial class USoundNodeModPlayer : USoundNodeAssetReferencer {
	///<summary>SoundModAssetPtr</summary>
	public TSoftObjectPtr<USoundMod> SoundModAssetPtr;
	///<summary>SoundMod</summary>
	public USoundMod SoundMod;
	///<summary>bLooping</summary>
	public bool bLooping;
}
