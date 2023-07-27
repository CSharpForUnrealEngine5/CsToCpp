#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceAsyncGpuTrace.h")]
///<summary>Data interface for handling latent (delayed 1 frame) traces against the scene for GPU simulations.</summary>
public partial class UNiagaraDataInterfaceAsyncGpuTrace : UNiagaraDataInterface {
// NiagaraDataInterfaceAsyncGpuTrace
	public int MaxTracesPerParticle;
	public int MaxRetraces;
	public ENDICollisionQuery_AsyncGpuTraceProvider TraceProvider;
}
