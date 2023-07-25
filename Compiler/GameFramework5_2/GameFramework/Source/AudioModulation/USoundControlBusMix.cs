#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundControlBusMix.h")]
public partial class USoundControlBusMix : UObject {
// SoundControlBusMix
	public void LoadMixFromProfile() {}
	public void SaveMixToProfile() {}
	public void SoloMix() {}
	public void ActivateMix() {}
	public void DeactivateMix() {}
	public void DeactivateAllMixes() {}
	public uint ProfileIndex;
	public TArray<FSoundControlBusMixStage> MixStages;
}
