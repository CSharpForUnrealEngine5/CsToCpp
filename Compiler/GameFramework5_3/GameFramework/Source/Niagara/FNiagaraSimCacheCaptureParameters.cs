namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimCacheCapture.h")]
public partial struct FNiagaraSimCacheCaptureParameters {
	public bool bAppendToSimCache;
	public bool bCaptureFixedNumberOfFrames;
	public int NumFrames;
	public int CaptureRate;
	public bool bUseTimeout;
	public int TimeoutFrameCount;
	public bool bCaptureAllFramesImmediatly;
	public float ImmediateCaptureDeltaTime;
}
