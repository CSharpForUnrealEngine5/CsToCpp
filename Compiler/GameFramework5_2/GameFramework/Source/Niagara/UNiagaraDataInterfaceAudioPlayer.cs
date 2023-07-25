#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceAudioPlayer.h")]
///<summary>This Data Interface can be used to play one-shot audio effects driven by particle data.</summary>
public partial class UNiagaraDataInterfaceAudioPlayer : UNiagaraDataInterface {
// NiagaraDataInterfaceAudioPlayer
	public USoundBase SoundToPlay;
	public USoundAttenuation Attenuation;
	public USoundConcurrency Concurrency;
	public TArray<string> ParameterNames;
	public FNiagaraUserParameterBinding ConfigurationUserParameter;
	public bool bLimitPlaysPerTick;
	public int MaxPlaysPerTick;
	public bool bStopWhenComponentIsDestroyed;
	public bool bAllowLoopingOneShotSounds;
	public bool bOnlyActiveDuringGameplay;
}
