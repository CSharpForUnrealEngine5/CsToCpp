#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Compile time data used by Data Channel interfaces.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelCommon.h")]
public partial struct FNDIDataChannelCompiledData {
	public TArray<FNDIDataChannelFunctionInfo> FunctionInfo;
	public TMap<FNiagaraCompileHash,FNDIDataChannel_GPUScriptParameterAccessInfo> GPUScriptParameterInfos;
	public uint TotalParams;
	public bool bUsedByCPU;
	public bool bUsedByGPU;
}
