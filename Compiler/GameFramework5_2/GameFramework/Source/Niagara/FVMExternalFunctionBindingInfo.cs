namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FVMExternalFunctionBindingInfo {
	public string Name;
	public string OwnerName;
	public TArray<bool> InputParamLocations;
	public int NumOutputs;
	public TArray<FVMFunctionSpecifier> FunctionSpecifiers;
	public TArray<FNiagaraVariableBase> VariadicInputs;
	public TArray<FNiagaraVariableBase> VariadicOutputs;
	public TMap<string,string> Specifiers_DEPRECATED;
}
