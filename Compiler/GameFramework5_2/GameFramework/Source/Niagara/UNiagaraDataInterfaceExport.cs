#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceExport.h")]
///<summary>This Data Interface can be used to gather particles at execution time and call either a</summary>
public partial class UNiagaraDataInterfaceExport : UNiagaraDataInterface {
// NiagaraDataInterfaceExport
	public FNiagaraUserParameterBinding CallbackHandlerParameter;
	public ENDIExport_GPUAllocationMode GPUAllocationMode;
	public int GPUAllocationFixedSize;
	public float GPUAllocationPerParticleSize;
}
