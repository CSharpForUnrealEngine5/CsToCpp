#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundClass.h")]
///<summary>Structure containing information on a SoundMix to activate passively.</summary>
public partial struct FPassiveSoundMixModifier {
// PassiveSoundMixModifier
	public USoundMix SoundMix;
	public float MinVolumeThreshold;
	public float MaxVolumeThreshold;
}
