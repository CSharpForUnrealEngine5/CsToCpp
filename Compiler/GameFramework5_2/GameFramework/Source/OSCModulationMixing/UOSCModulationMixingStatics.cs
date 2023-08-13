namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("OSCModulationMixingStatics.h")]
public partial class UOSCModulationMixingStatics : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Returns OSC Address pattern for loading a mix</summary>
	public static FOSCAddress GetMixLoadPattern() { return default; }
	///<summary>Returns OSC Address path for loading a profile</summary>
	public static FOSCAddress GetProfileLoadPath() { return default; }
	///<summary>Returns OSC Address path for saving a profile</summary>
	public static FOSCAddress GetProfileSavePath() { return default; }
	///<summary>Converts stage array to OSCBundle representation to send over network via OSC protocol</summary>
	public static void CopyStagesToOSCBundle(UObject WorldContextObject,FOSCAddress PathAddress,TArray<FSoundControlBusMixStage> Stages,FOSCBundle Bundle) {}
	///<summary>Converts Control Bus Mix to OSCBundle representation to send over network via OSC protocol</summary>
	public static void CopyMixToOSCBundle(UObject WorldContextObject,USoundControlBusMix Mix,FOSCBundle Bundle) {}
	///<summary>Returns whether bundle contains recognized payload of OSC Modulation Data</summary>
	public static EOSCModulationBundle GetOSCBundleType(FOSCBundle Bundle) { return default; }
	///<summary>Request mix update from server with loaded content.</summary>
	public static void RequestMix(UObject WorldContextObject,UOSCClient Client,FOSCAddress MixPath) {}
	///<summary>Converts OSCBundle to Control Bus Values &amp; Mix Path from which it came</summary>
	public static TArray<FSoundModulationMixValue> OSCBundleToStageValues(UObject WorldContextObject,FOSCBundle Bundle,FOSCAddress MixPath,TArray<FOSCAddress> BusPaths,TArray<string> BusClassNames) { return default; }
}
