#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelCommon.h")]
///<summary>Compile time data used by Data Channel interfaces.</summary>
public partial struct FNDIDataChannelCompiledData {
// NDIDataChannelCompiledData
	public TArray<FNDIDataChannelFunctionInfo> FunctionInfo;
	public TMap<FNiagaraCompileHash,FNDIDataChannel_GPUScriptParameterAccessInfo> GPUScriptParameterInfos;
	public uint TotalParams;
	public bool bUsedByCPU;
	public bool bUsedByGPU;
}
