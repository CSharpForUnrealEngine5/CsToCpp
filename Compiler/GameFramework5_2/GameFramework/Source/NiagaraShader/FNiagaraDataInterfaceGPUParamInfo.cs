#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraShared.h")]
///<summary>Data coming from that translator that describes parameters needed for each data interface.</summary>
public partial struct FNiagaraDataInterfaceGPUParamInfo {
// NiagaraDataInterfaceGPUParamInfo
	public string DataInterfaceHLSLSymbol;
	public string DIClassName;
	public uint ShaderParametersOffset;
	public TArray<FNiagaraDataInterfaceGeneratedFunction> GeneratedFunctions;
}
