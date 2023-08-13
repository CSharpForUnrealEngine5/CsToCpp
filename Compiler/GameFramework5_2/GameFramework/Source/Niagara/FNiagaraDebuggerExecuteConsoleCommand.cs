namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Command that will execute a console command on the debugger client.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerExecuteConsoleCommand {
	public string Command;
	public bool bRequiresWorld;
}
