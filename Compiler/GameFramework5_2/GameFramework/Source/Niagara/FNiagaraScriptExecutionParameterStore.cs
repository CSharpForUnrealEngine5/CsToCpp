#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Storage class containing actual runtime buffers to be used by the VM and the GPU.</summary>
[CppInclude("NiagaraScriptExecutionParameterStore.h")]
public partial struct FNiagaraScriptExecutionParameterStore {
	public int ParameterSize;
	public uint PaddedParameterSize;
	public TArray<FNiagaraScriptExecutionPaddingInfo> PaddingInfo;
	public bool bInitialized;
}
