#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
public partial class USoundscapeColor : UObject {
	///<summary>Sound to Play</summary>
	public USoundBase Sound;
	///<summary>Base Volume Scalar</summary>
	public float VolumeBase;
	///<summary>Base Pitch Scalar</summary>
	public float PitchBase;
	///<summary>Modulation behavior</summary>
	public FSoundscapeColorModulationSettings ModulationBehavior;
	///<summary>Playback behavior</summary>
	public FSoundscapeColorPlaybackSettings PlaybackBehavior;
	///<summary>Playback behavior</summary>
	public FSoundscapeColorSpawnSettings SpawnBehavior;
	///<summary>Delegate call for property changes</summary>
	public FOnSoundscapeColorParameterChanges OnSoundscapeColorParameterChanges;
}
