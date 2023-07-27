#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AudioModulationStatics.h")]
///<summary>namespace AudioModulation</summary>
public partial class UAudioModulationStatics : UBlueprintFunctionLibrary {
// AudioModulationStatics
	public static void ActivateBus(UObject WorldContextObject,USoundControlBus Bus) {}
	public static void ActivateBusMix(UObject WorldContextObject,USoundControlBusMix Mix) {}
	public static void ActivateGenerator(UObject WorldContextObject,USoundModulationGenerator Generator) {}
	public static USoundControlBus CreateBus(UObject WorldContextObject,string Name,USoundModulationParameter Parameter,bool Activate/*=true*/) { return default; }
	public static FSoundControlBusMixStage CreateBusMixStage(UObject WorldContextObject,USoundControlBus Bus,float Value,float AttackTime/*=0.1f*/,float ReleaseTime/*=0.1f*/) { return default; }
	public static USoundControlBusMix CreateBusMix(UObject WorldContextObject,string Name,TArray<FSoundControlBusMixStage> Stages,bool Activate) { return default; }
	public static USoundModulationParameter CreateModulationParameter(UObject WorldContextObject,string Name,UClass ParamClass,float DefaultValue) { return default; }
	public static USoundModulationGeneratorEnvelopeFollower CreateEnvelopeFollowerGenerator(UObject WorldContextObject,string Name,FEnvelopeFollowerGeneratorParams Params) { return default; }
	public static USoundModulationGeneratorLFO CreateLFOGenerator(UObject WorldContextObject,string Name,FSoundModulationLFOParams Params) { return default; }
	public static void DeactivateBus(UObject WorldContextObject,USoundControlBus Bus) {}
	public static void DeactivateBusMix(UObject WorldContextObject,USoundControlBusMix Mix) {}
	public static void DeactivateGenerator(UObject WorldContextObject,USoundModulationGenerator Generator) {}
	public static void SaveMixToProfile(UObject WorldContextObject,USoundControlBusMix Mix,int ProfileIndex/*=0*/) {}
	public static TArray<FSoundControlBusMixStage> LoadMixFromProfile(UObject WorldContextObject,USoundControlBusMix Mix,bool bActivate/*=true*/,int ProfileIndex/*=0*/) { return default; }
	public static void UpdateMix(UObject WorldContextObject,USoundControlBusMix Mix,TArray<FSoundControlBusMixStage> Stages,float FadeTime/*=-1.0f*/) {}
	public static void SetGlobalBusMixValue(UObject WorldContextObject,USoundControlBus Bus,float Value,float FadeTime/*=-1.0f*/) {}
	public static void ClearGlobalBusMixValue(UObject WorldContextObject,USoundControlBus Bus,float FadeTime/*=-1.0f*/) {}
	public static void ClearAllGlobalBusMixValues(UObject WorldContextObject,float FadeTime/*=-1.0f*/) {}
	public static void UpdateMixByFilter(UObject WorldContextObject,USoundControlBusMix Mix,string AddressFilter,UClass ParamClassFilter,USoundModulationParameter ParamFilter,float Value/*=1.0f*/,float FadeTime/*=-1.0f*/) {}
	public static void UpdateMixFromObject(UObject WorldContextObject,USoundControlBusMix Mix,float FadeTime/*=-1.0f*/) {}
	public static void UpdateModulator(UObject WorldContextObject,USoundModulatorBase Modulator) {}
	public static float GetModulatorValue(UObject WorldContextObject,USoundModulatorBase Modulator) { return default; }
	public static TSet<USoundModulatorBase> GetModulatorsFromDestination(FSoundModulationDestinationSettings Destination) { return default; }
}
