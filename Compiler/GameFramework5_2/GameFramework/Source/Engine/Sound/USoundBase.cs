#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sound/SoundBase.h")]
///<summary>The base class for a playable sound object</summary>
public partial class USoundBase : UObject {
// SoundBase
	public USoundClass SoundClassObject;
	public bool bDebug;
	public bool bOverrideConcurrency;
	public bool bOutputToBusOnly_DEPRECATED;
	public bool bEnableBusSends;
	public bool bEnableBaseSubmix;
	public bool bEnableSubmixSends;
	public bool bHasDelayNode;
	public bool bHasConcatenatorNode;
	public bool bHasVirtualizeWhenSilent_DEPRECATED;
	public bool bBypassVolumeScaleForPriority;
	public EVirtualizationMode VirtualizationMode;
	public byte MaxConcurrentResolutionRule_DEPRECATED;
	public USoundConcurrency SoundConcurrencySettings_DEPRECATED;
	public TSet<USoundConcurrency> ConcurrencySet;
	public FSoundConcurrencySettings ConcurrencyOverrides;
	public int MaxConcurrentPlayCount_DEPRECATED;
	public float Duration;
	public float MaxDistance;
	public float TotalSamples;
	public float Priority;
	public USoundAttenuation AttenuationSettings;
	public USoundSubmixBase SoundSubmixObject;
	public TArray<FSoundSubmixSendInfo> SoundSubmixSends;
	public USoundEffectSourcePresetChain SourceEffectChain;
	public TArray<FSoundSourceBusSendInfo> BusSends;
	public TArray<FSoundSourceBusSendInfo> PreEffectBusSends;
	public TArray<UAssetUserData> AssetUserData;
	public FSoundTimecodeOffset TimecodeOffset;
}
