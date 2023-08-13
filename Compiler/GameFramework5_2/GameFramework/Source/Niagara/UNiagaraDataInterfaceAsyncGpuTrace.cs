namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data interface for handling latent (delayed 1 frame) traces against the scene for GPU simulations.</summary>
[CppInclude("NiagaraDataInterfaceAsyncGpuTrace.h")]
public partial class UNiagaraDataInterfaceAsyncGpuTrace : UNiagaraDataInterface {
	public static UClass StaticClass() {return default;}
	///<summary>The maximum number of traces (per particle) that can be created per frame.  Defines the size of the preallocated</summary>
	public int MaxTracesPerParticle;
	///<summary>If a collision is rejected, how many times do we attempt to retrace from that collision point forward to find a new, valid collision.</summary>
	public int MaxRetraces;
	///<summary>Defines which technique is used to resolve the trace - see &#39;AsyncGpuTraceDI/Provider Priority&#39; in the Niagara project settings.</summary>
	public ENDICollisionQuery_AsyncGpuTraceProvider TraceProvider;
}
