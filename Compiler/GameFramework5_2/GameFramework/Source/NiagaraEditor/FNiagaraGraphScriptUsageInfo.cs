#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraGraph.h")]
///<summary>Container for UNiagaraGraph cached data for managing CompileIds and Traversals.</summary>
public partial struct FNiagaraGraphScriptUsageInfo {
// NiagaraGraphScriptUsageInfo
	public FGuid BaseId;
	public ENiagaraScriptUsage UsageType;
	public FGuid UsageId;
	public FNiagaraCompileHash CompileHash;
	public FNiagaraCompileHash CompileHashFromGraph;
	public FNiagaraCompileHash ReferenceHashFromGraph;
	public TArray<FNiagaraCompileHashVisitorDebugInfo> CompileLastObjects;
	public TArray<UNiagaraNode> Traversal;
	public TArray<byte> DataHash_DEPRECATED;
	public FGuid GeneratedCompileId_DEPRECATED;
}
