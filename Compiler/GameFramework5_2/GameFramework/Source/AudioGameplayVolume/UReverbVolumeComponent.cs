#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UReverbVolumeComponent - Audio Gameplay Volume component for reverb settings</summary>
[CppInclude("ReverbVolumeComponent.h")]
public partial class UReverbVolumeComponent : UAudioGameplayVolumeMutator {
	///<summary>SetReverbSettings</summary>
	public  void SetReverbSettings(FReverbSettings NewReverbSettings) {}
	///<summary>Reverb settings to use with this component</summary>
	public FReverbSettings ReverbSettings;
}
