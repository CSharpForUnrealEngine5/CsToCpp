#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The behavior of audio playback is defined within Sound Cues.</summary>
[CppInclude("Sound/SoundCue.h")]
public partial class USoundCue : USoundBase {
	public static UClass StaticClass() {return default;}
	///<summary>FirstNode</summary>
	public USoundNode FirstNode;
	///<summary>Base volume multiplier</summary>
	public float VolumeMultiplier;
	///<summary>Base pitch multiplier</summary>
	public float PitchMultiplier;
	///<summary>Attenuation settings to use if Override Attenuation is set to true</summary>
	public FSoundAttenuationSettings AttenuationOverrides;
	///<summary>AllNodes</summary>
	public TArray<USoundNode> AllNodes;
	///<summary>SoundCueGraph</summary>
	public UEdGraph SoundCueGraph;
	///<summary>The priority of the subtitle.  Defaults to 10000.  Higher values will play instead of lower values.</summary>
	public float SubtitlePriority;
	///<summary>Makes this sound cue automatically load any sound waves it can play into the cache when it is loaded.</summary>
	public bool bPrimeOnLoad;
	///<summary>Indicates whether attenuation should use the Attenuation Overrides or the Attenuation Settings asset</summary>
	public bool bOverrideAttenuation;
	///<summary>Ignore per-platform random node culling for memory purposes</summary>
	public bool bExcludeFromRandomNodeBranchCulling;
	///<summary>Whether a sound has play when silent enabled (i.e. for a sound cue, if any sound wave player has it enabled).</summary>
	public bool bHasPlayWhenSilent;
	///<summary>CookedQualityIndex</summary>
	public int CookedQualityIndex;
}
