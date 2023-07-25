#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCModulationMixingStatics.h")]
public partial class UOSCModulationMixingStatics : UBlueprintFunctionLibrary {
// OSCModulationMixingStatics
	public FOSCAddress GetMixLoadPattern() { return default; }
	public FOSCAddress GetProfileLoadPath() { return default; }
	public FOSCAddress GetProfileSavePath() { return default; }
	public void CopyStagesToOSCBundle(UObject WorldContextObject,FOSCAddress PathAddress,TArray<FSoundControlBusMixStage> Stages,FOSCBundle Bundle) {}
	public void CopyMixToOSCBundle(UObject WorldContextObject,UObject Mix,FOSCBundle Bundle) {}
	public EOSCModulationBundle GetOSCBundleType(FOSCBundle Bundle) { return default; }
	public void RequestMix(UObject WorldContextObject,UObject Client,FOSCAddress MixPath) {}
	public TArray<FSoundModulationMixValue> OSCBundleToStageValues(UObject WorldContextObject,FOSCBundle Bundle,FOSCAddress MixPath,TArray<FOSCAddress> BusPaths,TArray<string> BusClassNames) { return default; }
}
