namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraParameterBinding.h")]
public partial struct FNiagaraParameterBinding {
	public FNiagaraVariableBase ResolvedParameter;
	public FNiagaraVariableBase AliasedParameter;
	public TArray<UClass> AllowedDataInterfaces;
	public TArray<UClass> AllowedObjects;
	public TArray<UClass> AllowedInterfaces;
}
