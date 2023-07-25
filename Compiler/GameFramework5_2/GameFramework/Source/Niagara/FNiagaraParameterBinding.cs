#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterBinding.h")]
public partial struct FNiagaraParameterBinding {
// NiagaraParameterBinding
	public FNiagaraVariableBase Parameter;
	public FNiagaraVariableBase AliasedParameter;
	public TArray<UClass> AllowedDataInterfaces;
	public TArray<UClass> AllowedObjects;
	public TArray<UClass> AllowedInterfaces;
}
