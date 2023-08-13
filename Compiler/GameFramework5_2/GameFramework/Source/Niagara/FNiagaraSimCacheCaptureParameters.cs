namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheCapture.h")]
public partial struct FNiagaraSimCacheCaptureParameters {
	public int NumFrames;
	public int CaptureRate;
	public bool bManuallyAdvanceSimulation;
	public float AdvanceDeltaTime;
}
