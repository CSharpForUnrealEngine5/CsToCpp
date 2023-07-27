#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AttenuationVolumeComponent.h")]
///<summary>UAttenuationVolumeComponent - Audio Gameplay Volume component for occlusion settings (volume attenuation)</summary>
public partial class UAttenuationVolumeComponent : UAudioGameplayVolumeMutator {
// AttenuationVolumeComponent
	public  void SetExteriorVolume(float Volume,float InterpolateTime) {}
	public  void SetInteriorVolume(float Volume,float InterpolateTime) {}
	public float ExteriorVolume;
	public float ExteriorTime;
	public float InteriorVolume;
	public float InteriorTime;
}
