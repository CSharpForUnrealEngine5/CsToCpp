namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>namespace AudioModulation</summary>
[CppInclude("AudioModulationStatics.h")]
public partial class UAudioModulationStatics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Manually activates a modulation bus. If called, deactivation will only occur</summary>
	public static void ActivateBus(UObject WorldContextObject,USoundControlBus Bus) {}
	///<summary>Manually activates a bus modulator mix. If called, deactivation will only occur</summary>
	public static void ActivateBusMix(UObject WorldContextObject,USoundControlBusMix Mix) {}
	///<summary>Manually activates a modulation generator. If called, deactivation will only occur</summary>
	public static void ActivateGenerator(UObject WorldContextObject,USoundModulationGenerator Generator) {}
	///<summary>Creates a modulation bus with the provided default value.</summary>
	public static USoundControlBus CreateBus(UObject WorldContextObject,string Name,USoundModulationParameter Parameter,bool Activate/*=true*/) { return default; }
	///<summary>Creates a stage used to mix a control bus.</summary>
	public static FSoundControlBusMixStage CreateBusMixStage(UObject WorldContextObject,USoundControlBus Bus,float Value,float AttackTime/*=0.1f*/,float ReleaseTime/*=0.1f*/) { return default; }
	///<summary>Creates a modulation bus mix, with a bus stage set to the provided target value.</summary>
	public static USoundControlBusMix CreateBusMix(UObject WorldContextObject,string Name,TArray<FSoundControlBusMixStage> Stages,bool Activate) { return default; }
	///<summary>Creates a modulation parameter of a given class.</summary>
	public static USoundModulationParameter CreateModulationParameter(UObject WorldContextObject,string Name,UClass ParamClass,float DefaultValue) { return default; }
	///<summary>Creates a modulation generator based on an Envelope Follower with the given parameters.</summary>
	public static USoundModulationGeneratorEnvelopeFollower CreateEnvelopeFollowerGenerator(UObject WorldContextObject,string Name,FEnvelopeFollowerGeneratorParams Params) { return default; }
	///<summary>Creates a modulation generator based on an LFO with the given parameters.</summary>
	public static USoundModulationGeneratorLFO CreateLFOGenerator(UObject WorldContextObject,string Name,FSoundModulationLFOParams Params) { return default; }
	///<summary>Deactivates a bus. Does nothing if the provided bus is already inactive.</summary>
	public static void DeactivateBus(UObject WorldContextObject,USoundControlBus Bus) {}
	///<summary>Deactivates a modulation bus mix. Does nothing if an instance of the provided bus mix is already inactive.</summary>
	public static void DeactivateBusMix(UObject WorldContextObject,USoundControlBusMix Mix) {}
	///<summary>Deactivates a modulation generator. Does nothing if an instance of the provided generator is already inactive.</summary>
	public static void DeactivateGenerator(UObject WorldContextObject,USoundModulationGenerator Generator) {}
	///<summary>Saves control bus mix to a profile, serialized to an ini file.  If mix is loaded, uses current proxy&#39;s state.</summary>
	public static void SaveMixToProfile(UObject WorldContextObject,USoundControlBusMix Mix,int ProfileIndex/*=0*/) {}
	///<summary>Loads control bus mix from a profile into UObject mix definition, deserialized from an ini file.</summary>
	public static TArray<FSoundControlBusMixStage> LoadMixFromProfile(UObject WorldContextObject,USoundControlBusMix Mix,bool bActivate/*=true*/,int ProfileIndex/*=0*/) { return default; }
	///<summary>Sets a Control Bus Mix with the provided stage data, if the stages</summary>
	public static void UpdateMix(UObject WorldContextObject,USoundControlBusMix Mix,TArray<FSoundControlBusMixStage> Stages,float FadeTime/*=-1.0f*/) {}
	///<summary>Sets a Global Control Bus Mix with a single stage associated with the provided Bus to the given float value.  This call should</summary>
	public static void SetGlobalBusMixValue(UObject WorldContextObject,USoundControlBus Bus,float Value,float FadeTime/*=-1.0f*/) {}
	///<summary>Clears global control bus mix if set, using the applied fade time to return to the provided bus&#39;s parameter default value.</summary>
	public static void ClearGlobalBusMixValue(UObject WorldContextObject,USoundControlBus Bus,float FadeTime/*=-1.0f*/) {}
	///<summary>Clears all global control bus mix values if set, using the applied fade time to return all to their respective bus&#39;s parameter default value.</summary>
	public static void ClearAllGlobalBusMixValues(UObject WorldContextObject,float FadeTime/*=-1.0f*/) {}
	///<summary>Sets filtered stages of a given class to a provided target value for active instance of mix.</summary>
	public static void UpdateMixByFilter(UObject WorldContextObject,USoundControlBusMix Mix,string AddressFilter,UClass ParamClassFilter,USoundModulationParameter ParamFilter,float Value/*=1.0f*/,float FadeTime/*=-1.0f*/) {}
	///<summary>Commits updates from a UObject definition of a bus mix to active instance in audio thread</summary>
	public static void UpdateMixFromObject(UObject WorldContextObject,USoundControlBusMix Mix,float FadeTime/*=-1.0f*/) {}
	///<summary>Commits updates from a UObject definition of a modulator (e.g. Bus, Bus Mix, Generator)</summary>
	public static void UpdateModulator(UObject WorldContextObject,USoundModulatorBase Modulator) {}
	///<summary>Gets the (normalized) value of the given modulator.</summary>
	public static float GetModulatorValue(UObject WorldContextObject,USoundModulatorBase Modulator) { return default; }
	///<summary>Gets the list of modulators currently applied to a Modulation Destination.</summary>
	public static TSet<USoundModulatorBase> GetModulatorsFromDestination(FSoundModulationDestinationSettings Destination) { return default; }
}
