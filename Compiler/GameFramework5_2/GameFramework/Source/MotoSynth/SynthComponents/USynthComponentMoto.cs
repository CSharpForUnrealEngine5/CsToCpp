#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentMoto.h")]
public partial class USynthComponentMoto : USynthComponent {
	public static UClass StaticClass() {return default;}
	///<summary>The moto synth preset to use for the moto synth component.</summary>
	public UMotoSynthPreset MotoSynthPreset;
	///<summary>Sets the starting RPM of the engine</summary>
	public float RPM;
	///<summary>Sets the RPM of the granular engine directly.</summary>
	public  void SetRPM(float InRPM,float InTimeSec) {}
	///<summary>Sets a moto synth settings dynamically.</summary>
	public  void SetSettings(FMotoSynthRuntimeSettings InSettings) {}
	///<summary>Retrieves RPM range of the moto synth, taking into account the acceleration and deceleration sources. The min RPM is the largest of the min RPms of either and the max RPM is min of the max RPMs of either.</summary>
	public  void GetRPMRange(float OutMinRPM,float OutMaxRPM) {}
	///<summary>Returns if the moto synth is enabled.</summary>
	public  bool IsEnabled() { return default; }
}
