#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheCapture.h")]
public partial struct FNiagaraSimCacheCaptureParameters {
	public int NumFrames;
	public int CaptureRate;
	public bool bManuallyAdvanceSimulation;
	public float AdvanceDeltaTime;
}
