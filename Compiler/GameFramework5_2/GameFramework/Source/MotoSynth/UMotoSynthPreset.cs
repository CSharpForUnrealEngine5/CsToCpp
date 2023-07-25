#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MotoSynthPreset.h")]
///<summary>Asset used to store moto synth preset data.</summary>
public partial class UMotoSynthPreset : UObject {
// MotoSynthPreset
	public FRuntimeFloatCurve EnginePreviewRPMCurve;
	public FMotoSynthRuntimeSettings Settings;
	public void StartEnginePreview() {}
	public void StopEnginePreview() {}
	public void DumpRuntimeMemoryUsage() {}
}
