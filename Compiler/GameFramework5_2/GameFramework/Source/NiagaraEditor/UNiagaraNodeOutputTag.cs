namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeOutputTag.h")]
public partial class UNiagaraNodeOutputTag : UNiagaraNodeWithDynamicPins {
	public static UClass StaticClass() {return default;}
	///<summary>bEmitMessageOnFailure</summary>
	public bool bEmitMessageOnFailure;
	///<summary>FailureSeverity</summary>
	public FNiagaraCompileEventSeverity FailureSeverity;
}
