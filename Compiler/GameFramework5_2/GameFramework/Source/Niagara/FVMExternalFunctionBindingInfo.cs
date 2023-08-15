namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FVMExternalFunctionBindingInfo {
	public FName Name;
	public FName OwnerName;
	public TArray<bool> InputParamLocations;
	public int NumOutputs;
	public TArray<FVMFunctionSpecifier> FunctionSpecifiers;
	public TArray<FNiagaraVariableBase> VariadicInputs;
	public TArray<FNiagaraVariableBase> VariadicOutputs;
	public TMap<FName,FName> Specifiers_DEPRECATED;
}
