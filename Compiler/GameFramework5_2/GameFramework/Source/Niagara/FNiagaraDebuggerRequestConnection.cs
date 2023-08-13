namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Messaged broadcast from debugger to request a connection to a particular session.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerRequestConnection {
	public FGuid SessionId;
	public FGuid InstanceId;
}
