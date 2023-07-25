#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGraph.h")]
public partial class UNiagaraGraph : UEdGraph {
// NiagaraGraph
	public FGuid ChangeId;
	public FGuid ForceRebuildId;
	public FGuid LastBuiltTraversalDataChangeId;
	public FGuid LastBuiltScriptVersionId;
	public TArray<FNiagaraGraphScriptUsageInfo> CachedUsageInfo;
	public TMap<FNiagaraVariable,FNiagaraVariableMetaData> VariableToMetaData_DEPRECATED;
	public TMap<FNiagaraVariable,UNiagaraScriptVariable> VariableToScriptVariable;
	public TMap<FNiagaraVariable,FNiagaraGraphParameterReferenceCollection> ParameterToReferencesMap;
	public TArray<FNiagaraScriptVariableData> CompilationScriptVariables;
	public bool bHasValidLastBuiltScriptVersionId;
}
