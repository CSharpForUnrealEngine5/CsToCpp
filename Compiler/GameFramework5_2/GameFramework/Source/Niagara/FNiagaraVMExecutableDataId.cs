#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScript.h")]
///<summary>Struct containing all of the data necessary to look up a NiagaraScript's VM executable results from the Derived Data Cache.</summary>
public partial struct FNiagaraVMExecutableDataId {
// NiagaraVMExecutableDataId
	public FGuid CompilerVersionID;
	public ENiagaraScriptUsage ScriptUsageType;
	public FGuid ScriptUsageTypeID;
	public TArray<string> AdditionalDefines;
	public TArray<FNiagaraVariableBase> AdditionalVariables;
	public bool bUsesRapidIterationParams;
	public bool bDisableDebugSwitches;
	public bool bInterpolatedSpawn;
	public bool bRequiresPersistentIDs;
	public FGuid BaseScriptID_DEPRECATED;
	public FNiagaraCompileHash BaseScriptCompileHash;
	public TArray<FNiagaraCompileHash> ReferencedCompileHashes;
	public FGuid ScriptVersionID;
}
