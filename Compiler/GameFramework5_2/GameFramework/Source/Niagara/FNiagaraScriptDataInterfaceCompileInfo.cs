#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraCommon.h")]
public partial struct FNiagaraScriptDataInterfaceCompileInfo {
	public string Name;
	public int UserPtrIdx;
	public FNiagaraTypeDefinition Type;
	public TArray<FNiagaraFunctionSignature> RegisteredFunctions;
	public string RegisteredParameterMapRead;
	public string RegisteredParameterMapWrite;
	public bool bIsPlaceholder;
}
