#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelCommon.h")]
///<summary>Stores info for a function called on a DataChannel DI.</summary>
public partial struct FNDIDataChannelFunctionInfo {
// NDIDataChannelFunctionInfo
	public string FunctionName;
	public TArray<FNiagaraVariableBase> Inputs;
	public TArray<FNiagaraVariableBase> Outputs;
}
