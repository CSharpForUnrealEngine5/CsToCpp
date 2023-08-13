namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Message sent from a debugger client to a connected debugger containing the results of a sim cache capture.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraSystemSimCacheCaptureReply {
	public string ComponentName;
	public TArray<byte> SimCacheData;
}
