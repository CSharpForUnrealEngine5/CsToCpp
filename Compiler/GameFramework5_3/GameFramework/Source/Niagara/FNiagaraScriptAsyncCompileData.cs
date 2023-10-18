namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCompilationTypes.h")]
public partial struct FNiagaraScriptAsyncCompileData {
	public TArray<FNiagaraVariable> RapidIterationParameters;
	public TMap<FName,UNiagaraDataInterface> NamedDataInterfaces;
}
