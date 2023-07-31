#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Empty message informing a debugger client that the debugger is closing the connection.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerConnectionClosed {
	public FGuid SessionId;
	public FGuid InstanceId;
}
