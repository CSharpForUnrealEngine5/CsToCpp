namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraNodeDataSetBase.h")]
public partial class UNiagaraNodeDataSetBase : UNiagaraNode {
	public static UClass StaticClass() {return default;}
	///<summary>DataSet</summary>
	public FNiagaraDataSetID DataSet;
	///<summary>Variables</summary>
	public TArray<FNiagaraVariable> Variables;
	///<summary>VariableFriendlyNames</summary>
	public TArray<string> VariableFriendlyNames;
	///<summary>ExternalStructAsset</summary>
	public UStruct ExternalStructAsset;
}
