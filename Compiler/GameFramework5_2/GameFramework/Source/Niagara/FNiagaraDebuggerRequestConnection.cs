#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDebuggerCommon.h")]
///<summary>Messaged broadcast from debugger to request a connection to a particular session.</summary>
public partial struct FNiagaraDebuggerRequestConnection {
// NiagaraDebuggerRequestConnection
	public FGuid SessionId;
	public FGuid InstanceId;
}
