#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceCompileInfo {
// NiagaraScriptDataInterfaceCompileInfo
	public string Name;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public TArray<FNiagaraFunctionSignature> RegisteredFunctions;
	public string RegisteredParameterMapRead;
	public string RegisteredParameterMapWrite;
	public bool bIsPlaceholder;
}
