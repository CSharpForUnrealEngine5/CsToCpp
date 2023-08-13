namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data coming from that translator that describes parameters needed for each data interface.</summary>
[CppInclude("NiagaraShared.h")]
public partial struct FNiagaraDataInterfaceGPUParamInfo {
	public string DataInterfaceHLSLSymbol;
	public string DIClassName;
	public uint ShaderParametersOffset;
	public TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions;
}
