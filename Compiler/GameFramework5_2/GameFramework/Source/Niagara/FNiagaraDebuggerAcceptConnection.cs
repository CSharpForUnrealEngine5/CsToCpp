#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Response message from the a debugger client accepting a connection requested by a FNiagaraDebuggerRequestConnection message.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerAcceptConnection {
	public FGuid SessionId;
	public FGuid InstanceId;
}
