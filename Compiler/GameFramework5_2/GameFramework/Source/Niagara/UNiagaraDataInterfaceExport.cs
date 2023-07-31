#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This Data Interface can be used to gather particles at execution time and call either a</summary>
[CppInclude("NiagaraDataInterfaceExport.h")]
public partial class UNiagaraDataInterfaceExport : UNiagaraDataInterface {
	///<summary>Reference to a user parameter that should receive the particle data after the simulation tick. The supplied parameter object needs to implement the INiagaraParticleCallbackHandler interface.</summary>
	public FNiagaraUserParameterBinding CallbackHandlerParameter;
	///<summary>Sets the allocation scheme for the number of elements we reserve for the GPU.  The number of elements reserved should be as low as possible to improve performance.</summary>
	public ENDIExport_GPUAllocationMode GPUAllocationMode;
	///<summary>Reserve a fixed number of elements we can write per frame.  Once the limit is reached we ignore further writes.</summary>
	public int GPUAllocationFixedSize;
	///<summary>Uses the emitter property particle count * this to determine the number of elements we reserve for write per frame.  The console variable fx.Niagara.NDIExport.GPUMaxReadbackCount is used to cap the maximum.  Once the limit is reached we ignore further writes.</summary>
	public float GPUAllocationPerParticleSize;
}
