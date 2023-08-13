namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Data Interface can be used to play one-shot audio effects driven by particle data.</summary>
[CppInclude("NiagaraDataInterfaceAudioPlayer.h")]
public partial class UNiagaraDataInterfaceAudioPlayer : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Reference to the audio asset to play</summary>
	public USoundBase SoundToPlay;
	///<summary>Optional sound attenuation setting to use</summary>
	public USoundAttenuation Attenuation;
	///<summary>Optional sound concurrency setting to use</summary>
	public USoundConcurrency Concurrency;
	///<summary>A set of parameter names that can be referenced via index when setting sound cue parameters on persistent audio</summary>
	public TArray<string> ParameterNames;
	///<summary>If bound to a valid user parameter object of type UNiagaraDataInterfaceAudioPlayerSettings, then configured settings like sound attenuation are set via the user parameter. This allows the sound settings to be dynamically changed via blueprint or C++.</summary>
	public FNiagaraUserParameterBinding ConfigurationUserParameter;
	///<summary>bLimitPlaysPerTick</summary>
	public bool bLimitPlaysPerTick;
	///<summary>This sets the max number of sounds played each tick.</summary>
	public int MaxPlaysPerTick;
	///<summary>If false then it the audio component keeps playing after the niagara component was destroyed. Looping sounds are always stopped when the component is destroyed.</summary>
	public bool bStopWhenComponentIsDestroyed;
	///<summary>Playing looping sounds as persistent audio is not a problem, as the sound is stopped when a particle dies, but one-shot audio outlives the niagara system and can never be stopped.</summary>
	public bool bAllowLoopingOneShotSounds;
	///<summary>If true then this data interface only processes sounds during active gameplay. This is useful when you are working in the preview window and the sounds annoy you.</summary>
	public bool bOnlyActiveDuringGameplay;
}
