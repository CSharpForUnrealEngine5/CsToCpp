namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGraph.h")]
public partial class UNiagaraGraph : UEdGraph {
	public static UClass StaticClass() {return default;}
	///<summary>The current change identifier for this graph overall. Used to sync status with UNiagaraScripts.</summary>
	public FGuid ChangeId;
	///<summary>Internal value used to invalidate a DDC key for the script no matter what.</summary>
	public FGuid ForceRebuildId;
	///<summary>LastBuiltTraversalDataChangeId</summary>
	public FGuid LastBuiltTraversalDataChangeId;
	///<summary>The script version that was used when the cached CompileId was generated, a change</summary>
	public FGuid LastBuiltScriptVersionId;
	///<summary>CachedUsageInfo</summary>
	public TArray<FNiagaraGraphScriptUsageInfo> CachedUsageInfo;
	///<summary>Storage of meta-data for variables defined for use explicitly with this graph.</summary>
	public TMap<FNiagaraVariable,FNiagaraVariableMetaData> VariableToMetaData_DEPRECATED;
	///<summary>Storage of variables defined for use with this graph.</summary>
	public TMap<FNiagaraVariable,UNiagaraScriptVariable> VariableToScriptVariable;
	///<summary>A map of parameters in the graph to their referencers.</summary>
	public TMap<FNiagaraVariable,FNiagaraGraphParameterReferenceCollection> ParameterToReferencesMap;
	///<summary>CompilationScriptVariables</summary>
	public TArray<FNiagaraScriptVariableData> CompilationScriptVariables;
	///<summary>Used in conjunction with LastBuiltScriptVersionId to note that we&#39;ve got a valid script Id stored.</summary>
	public bool bHasValidLastBuiltScriptVersionId;
}
