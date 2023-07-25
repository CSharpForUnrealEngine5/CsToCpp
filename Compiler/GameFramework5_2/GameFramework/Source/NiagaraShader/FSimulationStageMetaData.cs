#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptBase.h")]
public partial struct FSimulationStageMetaData {
// SimulationStageMetaData
	public string SimulationStageName;
	public string EnabledBinding;
	public string ElementCountXBinding;
	public string ElementCountYBinding;
	public string ElementCountZBinding;
	public ENiagaraIterationSource IterationSourceType;
	public string IterationDataInterface;
	public string IterationDirectBinding;
	public ENiagaraSimStageExecuteBehavior ExecuteBehavior;
	public bool bWritesParticles;
	public bool bPartialParticleUpdate;
	public bool bParticleIterationStateEnabled;
	public bool bGpuIndirectDispatch;
	public string ParticleIterationStateBinding;
	public FIntPoint ParticleIterationStateRange;
	public TArray<string> OutputDestinations;
	public TArray<string> InputDataInterfaces;
	public int NumIterations;
	public string NumIterationsBinding;
	public ENiagaraGpuDispatchType GpuDispatchType;
	public ENiagaraDirectDispatchElementType GpuDirectDispatchElementType;
	public FIntVector GpuDispatchNumThreads;
}
