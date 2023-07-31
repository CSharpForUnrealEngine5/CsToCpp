#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UAttenuationVolumeComponent - Audio Gameplay Volume component for occlusion settings (volume attenuation)</summary>
[CppInclude("AttenuationVolumeComponent.h")]
public partial class UAttenuationVolumeComponent : UAudioGameplayVolumeMutator {
	///<summary>SetExteriorVolume</summary>
	public  void SetExteriorVolume(float Volume,float InterpolateTime) {}
	///<summary>SetInteriorVolume</summary>
	public  void SetInteriorVolume(float Volume,float InterpolateTime) {}
	///<summary>The desired volume of sounds outside the volume when the player is inside the volume</summary>
	public float ExteriorVolume;
	///<summary>The time over which to interpolate from the current volume to the desired volume of sounds outside the volume when the player enters the volume</summary>
	public float ExteriorTime;
	///<summary>The desired volume of sounds inside the volume when the player is outside the volume</summary>
	public float InteriorVolume;
	///<summary>The time over which to interpolate from the current volume to the desired volume of sounds inside the volume when the player enters the volume</summary>
	public float InteriorTime;
}
