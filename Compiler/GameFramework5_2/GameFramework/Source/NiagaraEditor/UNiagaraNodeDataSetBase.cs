#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeDataSetBase.h")]
public partial class UNiagaraNodeDataSetBase : UNiagaraNode {
// NiagaraNodeDataSetBase
	public FNiagaraDataSetID DataSet;
	public TArray<FNiagaraVariable> Variables;
	public TArray<string> VariableFriendlyNames;
	public UStruct ExternalStructAsset;
}
