#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The base class for a playable sound object</summary>
[CppInclude("Sound/SoundBase.h")]
public partial class USoundBase : UObject {
	///<summary>Sound class this sound belongs to</summary>
	public USoundClass SoundClassObject;
	///<summary>When &quot;au.3dVisualize.Attenuation&quot; has been specified, draw this sound&#39;s attenuation shape when the sound is audible. For debugging purposes only.</summary>
	public bool bDebug;
	///<summary>Whether or not to override the sound concurrency object with local concurrency settings.</summary>
	public bool bOverrideConcurrency;
	///<summary>Whether or not to only send this audio&#39;s output to a bus. If true, will not be this sound won&#39;t be audible except through bus sends.</summary>
	public bool bOutputToBusOnly_DEPRECATED;
	///<summary>Whether or not to enable sending this audio&#39;s output to buses.</summary>
	public bool bEnableBusSends;
	///<summary>If enabled, sound will route to the Master Submix by default or to the Base Submix if defined. If disabled, sound will route ONLY to the Submix Sends and/or Bus Sends</summary>
	public bool bEnableBaseSubmix;
	///<summary>Whether or not to enable Submix Sends other than the Base Submix.</summary>
	public bool bEnableSubmixSends;
	///<summary>Whether or not this sound has a delay node</summary>
	public bool bHasDelayNode;
	///<summary>Whether or not this sound has a concatenator node. If it does, we have to allow the sound to persist even though it may not have generate audible audio in a given audio thread frame.</summary>
	public bool bHasConcatenatorNode;
	///<summary>bHasVirtualizeWhenSilent_DEPRECATED</summary>
	public bool bHasVirtualizeWhenSilent_DEPRECATED;
	///<summary>Bypass volume weighting priority upon evaluating whether sound should remain active when max channel count is met (See platform Audio Settings).</summary>
	public bool bBypassVolumeScaleForPriority;
	///<summary>Virtualization behavior, determining if a sound may revive and how it continues playing when culled or evicted (limited to looping sounds).</summary>
	public EVirtualizationMode VirtualizationMode;
	///<summary>MaxConcurrentResolutionRule_DEPRECATED</summary>
	public EMaxConcurrentResolutionRule MaxConcurrentResolutionRule_DEPRECATED;
	///<summary>If Override Concurrency is false, the sound concurrency settings to use for this sound.</summary>
	public USoundConcurrency SoundConcurrencySettings_DEPRECATED;
	///<summary>Set of concurrency settings to observe (if override is set to false).  Sound must pass all concurrency settings to play.</summary>
	public TSet<USoundConcurrency> ConcurrencySet;
	///<summary>If Override Concurrency is true, concurrency settings to use.</summary>
	public FSoundConcurrencySettings ConcurrencyOverrides;
	///<summary>Maximum number of times this sound can be played concurrently.</summary>
	public int MaxConcurrentPlayCount_DEPRECATED;
	///<summary>Duration of sound in seconds.</summary>
	public float Duration;
	///<summary>The max distance of the asset, as determined by attenuation settings.</summary>
	public float MaxDistance;
	///<summary>Total number of samples (in the thousands). Useful as a metric to analyze the relative size of a given sound asset in content browser.</summary>
	public float TotalSamples;
	///<summary>Used to determine whether sound can play or remain active if channel limit is met, where higher value is higher priority</summary>
	public float Priority;
	///<summary>Attenuation settings package for the sound</summary>
	public USoundAttenuation AttenuationSettings;
	///<summary>Submix to route sound output to. If unset, falls back to referenced SoundClass submix.</summary>
	public USoundSubmixBase SoundSubmixObject;
	///<summary>Array of submix sends to which a prescribed amount (see &#39;Send Level&#39;) of this sound is sent.</summary>
	public TArray<FSoundSubmixSendInfo> SoundSubmixSends;
	///<summary>The source effect chain to use for this sound.</summary>
	public USoundEffectSourcePresetChain SourceEffectChain;
	///<summary>This sound will send its audio output to this list of buses if there are bus instances playing after source effects are processed.</summary>
	public TArray<FSoundSourceBusSendInfo> BusSends;
	///<summary>This sound will send its audio output to this list of buses if there are bus instances playing before source effects are processed.</summary>
	public TArray<FSoundSourceBusSendInfo> PreEffectBusSends;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
	///<summary>TimecodeOffset</summary>
	public FSoundTimecodeOffset TimecodeOffset;
}
