#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundCue.h")]
///<summary>The behavior of audio playback is defined within Sound Cues.</summary>
public partial class USoundCue : USoundBase {
// SoundCue
	public USoundNode FirstNode;
	public float VolumeMultiplier;
	public float PitchMultiplier;
	public FSoundAttenuationSettings AttenuationOverrides;
	public TArray<USoundNode> AllNodes;
	public UEdGraph SoundCueGraph;
	public float SubtitlePriority;
	public bool bPrimeOnLoad;
	public bool bOverrideAttenuation;
	public bool bExcludeFromRandomNodeBranchCulling;
	public bool bHasPlayWhenSilent;
	public int CookedQualityIndex;
}
