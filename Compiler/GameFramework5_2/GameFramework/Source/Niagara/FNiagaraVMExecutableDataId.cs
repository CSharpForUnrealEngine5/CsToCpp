#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct containing all of the data necessary to look up a NiagaraScript&#39;s VM executable results from the Derived Data Cache.</summary>
[CppInclude("NiagaraScript.h")]
public partial struct FNiagaraVMExecutableDataId {
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
