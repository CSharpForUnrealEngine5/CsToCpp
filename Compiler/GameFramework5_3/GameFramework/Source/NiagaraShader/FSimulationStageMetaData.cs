namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraScriptBase.h")]
public partial struct FSimulationStageMetaData {
	public FName SimulationStageName;
	public FName EnabledBinding;
	public FIntVector ElementCount;
	public FName ElementCountXBinding;
	public FName ElementCountYBinding;
	public FName ElementCountZBinding;
	public ENiagaraIterationSource IterationSourceType;
	public FName IterationDataInterface;
	public FName IterationDirectBinding;
	public ENiagaraSimStageExecuteBehavior ExecuteBehavior;
	public bool bWritesParticles;
	public bool bPartialParticleUpdate;
	public bool bParticleIterationStateEnabled;
	public bool bGpuIndirectDispatch;
	public FName ParticleIterationStateBinding;
	public FIntPoint ParticleIterationStateRange;
	public TArray<FName> OutputDestinations;
	public TArray<FName> InputDataInterfaces;
	public int NumIterations;
	public FName NumIterationsBinding;
	public ENiagaraGpuDispatchType GpuDispatchType;
	public ENiagaraDirectDispatchElementType GpuDirectDispatchElementType;
	public FIntVector GpuDispatchNumThreads;
}
