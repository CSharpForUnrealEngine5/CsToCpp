#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("SynthComponents/SynthComponentMoto.h")]
public partial class USynthComponentMoto : USynthComponent {
// SynthComponentMoto
	public UMotoSynthPreset MotoSynthPreset;
	public float RPM;
	public void SetRPM(float InRPM,float InTimeSec) {}
	public void SetSettings(FMotoSynthRuntimeSettings InSettings) {}
	public void GetRPMRange(float OutMinRPM,float OutMaxRPM) {}
	public bool IsEnabled() { return default; }
}
