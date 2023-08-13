namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Stores info for a function called on a DataChannel DI.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelCommon.h")]
public partial struct FNDIDataChannelFunctionInfo {
	public string FunctionName;
	public TArray<FNiagaraVariableBase> Inputs;
	public TArray<FNiagaraVariableBase> Outputs;
}
