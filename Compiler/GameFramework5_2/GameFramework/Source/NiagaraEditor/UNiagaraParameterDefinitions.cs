#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterDefinitions.h")]
///<summary>Collection of UNiagaraScriptVariables to synchronize between UNiagaraScripts.</summary>
public partial class UNiagaraParameterDefinitions : UNiagaraParameterDefinitionsBase {
// NiagaraParameterDefinitions
	public bool bPromoteToTopInAddMenus;
	public int MenuSortOrder;
	public TArray<UNiagaraScriptVariable> ScriptVariables;
	public TArray<FParameterDefinitionsBindingNameSubscription> ExternalParameterDefinitionsSubscriptions;
}
