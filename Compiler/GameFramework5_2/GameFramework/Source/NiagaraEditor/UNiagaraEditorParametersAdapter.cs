#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraEditorData.h")]
///<summary>An interface for editor only data which owns UNiagaraScriptVariables and supports synchronizing them with definitions.</summary>
public partial class UNiagaraEditorParametersAdapter : UNiagaraEditorParametersAdapterBase {
// NiagaraEditorParametersAdapter
	public TArray<UNiagaraScriptVariable> EditorOnlyScriptVars;
}
