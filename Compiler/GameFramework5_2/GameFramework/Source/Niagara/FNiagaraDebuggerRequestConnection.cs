#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Messaged broadcast from debugger to request a connection to a particular session.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerRequestConnection {
	public FGuid SessionId;
	public FGuid InstanceId;
}
