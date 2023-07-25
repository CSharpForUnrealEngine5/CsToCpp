#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceDataChannelWrite.h")]
public partial class UNiagaraDataInterfaceDataChannelWrite : UNiagaraDataInterface {
// NiagaraDataInterfaceDataChannelWrite
	public ENiagaraDataChannelAllocationMode AllocationMode;
	public uint AllocationCount;
	public bool bPublishToGame;
	public bool bPublishToCPU;
	public bool bPublishToGPU;
	public FNiagaraDataChannelReference Channel;
	public FNDIDataChannelWriteCompiledData CompiledData;
}
