#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimulationStageBase.h")]
public partial class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase {
// NiagaraSimulationStageGeneric
	public FNiagaraVariableAttributeBinding EnabledBinding;
	public ENiagaraIterationSource IterationSource;
	public int Iterations;
	public FNiagaraVariableAttributeBinding NumIterationsBinding;
	public ENiagaraSimStageExecuteBehavior ExecuteBehavior;
	public bool bDisablePartialParticleUpdate;
	public FNiagaraVariableDataInterfaceBinding DataInterface;
	public bool bParticleIterationStateEnabled;
	public FNiagaraVariableAttributeBinding ParticleIterationStateBinding;
	public FIntPoint ParticleIterationStateRange;
	public bool bGpuDispatchForceLinear;
	public bool bOverrideGpuDispatchNumThreads;
	public FIntVector OverrideGpuDispatchNumThreads;
	public ENiagaraGpuDispatchType DirectDispatchType;
	public ENiagaraDirectDispatchElementType DirectDispatchElementType;
	public FNiagaraVariableAttributeBinding ElementCountXBinding;
	public FNiagaraVariableAttributeBinding ElementCountYBinding;
	public FNiagaraVariableAttributeBinding ElementCountZBinding;
	public FNiagaraVariableAttributeBinding ElementCountBinding_DEPRECATED;
	public bool bSpawnOnly_DEPRECATED;
	public bool bOverrideGpuDispatchType_DEPRECATED;
	public ENiagaraGpuDispatchType OverrideGpuDispatchType_DEPRECATED;
}
