#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Collection of UNiagaraScriptVariables to synchronize between UNiagaraScripts.</summary>
[CppInclude("NiagaraParameterDefinitions.h")]
public partial class UNiagaraParameterDefinitions : UNiagaraParameterDefinitionsBase {
	///<summary>If true then these parameters will appear as top level entry in add menus (e.g. in the module editor)</summary>
	public bool bPromoteToTopInAddMenus;
	///<summary>Defines the sort order in add menus. Entries with smaller numbers are displayed first.</summary>
	public int MenuSortOrder;
	///<summary>ScriptVariables</summary>
	public TArray<UNiagaraScriptVariable> ScriptVariables;
	///<summary>ExternalParameterDefinitionsSubscriptions</summary>
	public TArray<FParameterDefinitionsBindingNameSubscription> ExternalParameterDefinitionsSubscriptions;
}
