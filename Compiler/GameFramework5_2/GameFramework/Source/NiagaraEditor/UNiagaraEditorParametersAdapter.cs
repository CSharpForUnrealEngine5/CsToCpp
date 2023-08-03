#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An interface for editor only data which owns UNiagaraScriptVariables and supports synchronizing them with definitions.</summary>
[CppInclude("NiagaraEditorData.h")]
public partial class UNiagaraEditorParametersAdapter : UNiagaraEditorParametersAdapterBase {
	public static UClass StaticClass() {return default;}
	///<summary>EditorOnlyScriptVars</summary>
	public TArray<UNiagaraScriptVariable> EditorOnlyScriptVars;
}
