#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct</summary>
[CppInclude("SoundscapeColor.h")]
public partial struct FSoundscapeColorModulationSettings {
	public bool bRandomizeVolume;
	public float VolumeMin;
	public float VolumeMax;
	public bool bRandomizePitch;
	public float PitchMin;
	public float PitchMax;
	public bool bFadeVolume;
	public float MinFadeInTime;
	public float MaxFadeInTime;
	public float MinFadeOutTime;
	public float MaxFadeOutTime;
	public bool bOnlyFadeInOnRetrigger;
}
