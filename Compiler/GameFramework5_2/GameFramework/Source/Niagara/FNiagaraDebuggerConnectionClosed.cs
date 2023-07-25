#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Empty message informing a debugger client that the debugger is closing the connection.</summary>
public partial struct FNiagaraDebuggerConnectionClosed {
// NiagaraDebuggerConnectionClosed
	public FGuid SessionId;
	public FGuid InstanceId;
}
