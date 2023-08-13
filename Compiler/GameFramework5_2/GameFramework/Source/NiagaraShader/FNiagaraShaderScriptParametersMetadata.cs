namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data provided from the translator to track information requires to bind data interface or parameters at runtime.</summary>
[CppInclude("NiagaraShared.h")]
public partial struct FNiagaraShaderScriptParametersMetadata {
	public TArray<FNiagaraDataInterfaceGPUParamInfo> DataInterfaceParamInfo;
	public TArray<string> LooseMetadataNames;
	public bool bExternalConstantsInterpolated;
	public TArray<FNiagaraShaderScriptExternalConstant> ExternalConstants;
}
