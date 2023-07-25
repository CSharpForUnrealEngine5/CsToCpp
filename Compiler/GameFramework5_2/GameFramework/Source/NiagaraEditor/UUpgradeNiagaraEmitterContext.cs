#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("UpgradeNiagaraScriptResults.h")]
///<summary>Wrapper class for passing results back from the version upgrade python script.</summary>
public partial class UUpgradeNiagaraEmitterContext : UObject {
// UpgradeNiagaraEmitterContext
	public bool bCancelledByPythonError;
	public UNiagaraPythonEmitter OldEmitter;
	public UNiagaraPythonEmitter NewEmitter;
}
