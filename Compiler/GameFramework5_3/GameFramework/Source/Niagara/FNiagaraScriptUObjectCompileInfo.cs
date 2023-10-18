namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptUObjectCompileInfo {
	public FNiagaraVariableBase Variable;
	public UObject Object;
	public FSoftObjectPath ObjectPath;
	public FName RegisteredParameterMapRead;
	public TArray<FName> RegisteredParameterMapWrites;
}
