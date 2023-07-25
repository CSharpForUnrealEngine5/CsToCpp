#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataChannel.h")]
public partial class UNiagaraDataChannel : UObject {
// NiagaraDataChannel
	public string ChannelName;
	public TArray<FNiagaraVariable> Variables;
	public bool bKeepPreviousFrameData;
	public FNiagaraDataSetCompiledData CompiledData;
	public FNiagaraDataSetCompiledData CompiledDataGPU;
	public FNiagaraDataChannelGameDataLayout GameDataLayout;
}
