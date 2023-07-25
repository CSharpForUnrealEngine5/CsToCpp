#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Response message from the a debugger client accepting a connection requested by a FNiagaraDebuggerRequestConnection message.</summary>
public partial struct FNiagaraDebuggerAcceptConnection {
// NiagaraDebuggerAcceptConnection
	public FGuid SessionId;
	public FGuid InstanceId;
}
