#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SoundscapeColor.h")]
public partial class USoundscapeColor : UObject {
// SoundscapeColor
	public USoundBase Sound;
	public float VolumeBase;
	public float PitchBase;
	public FSoundscapeColorModulationSettings ModulationBehavior;
	public FSoundscapeColorPlaybackSettings PlaybackBehavior;
	public FSoundscapeColorSpawnSettings SpawnBehavior;
	public FOnSoundscapeColorParameterChanges OnSoundscapeColorParameterChanges;
}
