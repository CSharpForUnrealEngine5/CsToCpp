namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure containing information on a SoundMix to activate passively.</summary>
[CppInclude("Sound/SoundClass.h")]
public partial struct FPassiveSoundMixModifier {
	public USoundMix SoundMix;
	public float MinVolumeThreshold;
	public float MaxVolumeThreshold;
}
