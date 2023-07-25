#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraShared.h")]
///<summary>Data provided from the translator to track information requires to bind data interface or parameters at runtime.</summary>
public partial struct FNiagaraShaderScriptParametersMetadata {
// NiagaraShaderScriptParametersMetadata
	public TArray<FNiagaraDataInterfaceGPUParamInfo> DataInterfaceParamInfo;
	public TArray<string> LooseMetadataNames;
	public bool bExternalConstantsInterpolated;
	public TArray<FNiagaraShaderScriptExternalConstant> ExternalConstants;
}
