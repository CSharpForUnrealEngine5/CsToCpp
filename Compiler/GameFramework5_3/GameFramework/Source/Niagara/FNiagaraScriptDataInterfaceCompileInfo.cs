namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceCompileInfo {
	public FName Name;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public TArray<FNiagaraFunctionSignature> RegisteredFunctions;
	public FName RegisteredParameterMapRead;
	public FName RegisteredParameterMapWrite;
	public bool bIsPlaceholder;
	public string SourceEmitterName;
}
