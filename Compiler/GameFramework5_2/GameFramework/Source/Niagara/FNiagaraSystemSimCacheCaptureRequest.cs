#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Message sent from the debugger to a client to request a sim cache capture for a particular component.</summary>
public partial struct FNiagaraSystemSimCacheCaptureRequest {
// NiagaraSystemSimCacheCaptureRequest
	public string ComponentName;
	public uint CaptureDelayFrames;
	public uint CaptureFrames;
}
