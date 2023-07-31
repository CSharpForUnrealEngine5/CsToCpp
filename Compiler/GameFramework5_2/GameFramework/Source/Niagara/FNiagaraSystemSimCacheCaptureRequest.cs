#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message sent from the debugger to a client to request a sim cache capture for a particular component.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraSystemSimCacheCaptureRequest {
	public string ComponentName;
	public uint CaptureDelayFrames;
	public uint CaptureFrames;
}
