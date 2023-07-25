#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptExecutionParameterStore.h")]
///<summary>Storage class containing actual runtime buffers to be used by the VM and the GPU.</summary>
public partial struct FNiagaraScriptExecutionParameterStore {
// NiagaraScriptExecutionParameterStore
	public int ParameterSize;
	public uint PaddedParameterSize;
	public TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo;
	public bool bInitialized;
}
