#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Command that will execute a console command on the debugger client.</summary>
[CppInclude("NiagaraDebuggerCommon.h")]
public partial struct FNiagaraDebuggerExecuteConsoleCommand {
	public string Command;
	public bool bRequiresWorld;
}
