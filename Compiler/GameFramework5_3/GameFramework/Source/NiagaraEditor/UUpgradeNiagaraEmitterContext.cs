namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Wrapper class for passing results back from the version upgrade python script.</summary>
[CppInclude("UpgradeNiagaraScriptResults.h")]
public partial class UUpgradeNiagaraEmitterContext : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether the converter process was cancelled due to an unrecoverable error in the python script process.</summary>
	public bool bCancelledByPythonError;
	///<summary>OldEmitter</summary>
	public UNiagaraPythonEmitter OldEmitter;
	///<summary>NewEmitter</summary>
	public UNiagaraPythonEmitter NewEmitter;
}
