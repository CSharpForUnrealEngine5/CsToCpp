#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Message sent from a debugger client to a connected debugger containing the results of a sim cache capture.</summary>
public partial struct FNiagaraSystemSimCacheCaptureReply {
// NiagaraSystemSimCacheCaptureReply
	public string ComponentName;
	public TArray<byte> SimCacheData;
}
