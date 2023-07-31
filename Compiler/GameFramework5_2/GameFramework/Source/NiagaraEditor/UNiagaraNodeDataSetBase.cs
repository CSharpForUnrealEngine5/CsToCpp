#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeDataSetBase.h")]
public partial class UNiagaraNodeDataSetBase : UNiagaraNode {
	///<summary>DataSet</summary>
	public FNiagaraDataSetID DataSet;
	///<summary>Variables</summary>
	public TArray<FNiagaraVariable> Variables;
	///<summary>VariableFriendlyNames</summary>
	public TArray<string> VariableFriendlyNames;
	///<summary>ExternalStructAsset</summary>
	public UStruct ExternalStructAsset;
}
