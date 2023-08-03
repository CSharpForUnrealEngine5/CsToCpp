#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UFilterVolumeComponent - Audio Gameplay Volume component for occlusion settings (volume filter)</summary>
[CppInclude("FilterVolumeComponent.h")]
public partial class UFilterVolumeComponent : UAudioGameplayVolumeMutator {
	public static UClass StaticClass() {return default;}
	///<summary>SetExteriorLPF</summary>
	public  void SetExteriorLPF(float Volume,float InterpolateTime) {}
	///<summary>SetInteriorLPF</summary>
	public  void SetInteriorLPF(float Volume,float InterpolateTime) {}
	///<summary>The desired LPF frequency cutoff (in hertz) of sounds outside the volume when the player is inside the volume</summary>
	public float ExteriorLPF;
	///<summary>The time over which to interpolate from the current LPF to the desired LPF of sounds outside the volume when the player enters the volume</summary>
	public float ExteriorLPFTime;
	///<summary>The desired LPF frequency cutoff (in hertz) of sounds inside the volume when the player is outside the volume</summary>
	public float InteriorLPF;
	///<summary>The time over which to interpolate from the current LPF to the desired LPF of sounds inside the volume when the player enters the volume</summary>
	public float InteriorLPFTime;
}
