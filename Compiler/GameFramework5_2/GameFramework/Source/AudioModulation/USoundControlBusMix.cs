#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundControlBusMix.h")]
public partial class USoundControlBusMix : UObject {
	///<summary>Loads the mix from the provided profile index</summary>
	public  void LoadMixFromProfile() {}
	///<summary>Saves the mix to the provided profile index</summary>
	public  void SaveMixToProfile() {}
	///<summary>Solos this mix, deactivating all others and activating this</summary>
	public  void SoloMix() {}
	///<summary>Activates this mix in all active worlds</summary>
	public  void ActivateMix() {}
	///<summary>Deactivates this mix in all active worlds</summary>
	public  void DeactivateMix() {}
	///<summary>Deactivates all mixes in all active worlds</summary>
	public  void DeactivateAllMixes() {}
	///<summary>ProfileIndex</summary>
	public uint ProfileIndex;
	///<summary>Array of stages controlled by mix.</summary>
	public TArray<FSoundControlBusMixStage> MixStages;
}
