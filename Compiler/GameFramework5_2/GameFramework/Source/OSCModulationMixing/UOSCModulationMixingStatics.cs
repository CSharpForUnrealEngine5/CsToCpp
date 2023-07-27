#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCModulationMixingStatics.h")]
public partial class UOSCModulationMixingStatics : UBlueprintFunctionLibrary {
// OSCModulationMixingStatics
	public static FOSCAddress GetMixLoadPattern() { return default; }
	public static FOSCAddress GetProfileLoadPath() { return default; }
	public static FOSCAddress GetProfileSavePath() { return default; }
	public static void CopyStagesToOSCBundle(UObject WorldContextObject,FOSCAddress PathAddress,TArray<FSoundControlBusMixStage> Stages,FOSCBundle Bundle) {}
	public static void CopyMixToOSCBundle(UObject WorldContextObject,USoundControlBusMix Mix,FOSCBundle Bundle) {}
	public static EOSCModulationBundle GetOSCBundleType(FOSCBundle Bundle) { return default; }
	public static void RequestMix(UObject WorldContextObject,UOSCClient Client,FOSCAddress MixPath) {}
	public static TArray<FSoundModulationMixValue> OSCBundleToStageValues(UObject WorldContextObject,FOSCBundle Bundle,FOSCAddress MixPath,TArray<FOSCAddress> BusPaths,TArray<string> BusClassNames) { return default; }
}
