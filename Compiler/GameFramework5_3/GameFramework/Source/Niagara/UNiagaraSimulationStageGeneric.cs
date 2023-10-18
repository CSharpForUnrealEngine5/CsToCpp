namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimulationStageBase.h")]
public partial class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase {
	public static UClass StaticClass() {return default;}
	///<summary>Optional bool binding allowing scripts to control if the simulation stage is enabled or not.</summary>
	public FNiagaraVariableAttributeBinding EnabledBinding;
	///<summary>Select what we should be iterating over, particles or data interfaces.</summary>
	public ENiagaraIterationSource IterationSource;
	///<summary>Number of times (or iterations) the simulation stage will execute in a row.</summary>
	public FNiagaraParameterBindingWithValue NumIterations;
	///<summary>Controls when the simulation stage should execute, only valid for data interface iteration stages</summary>
	public ENiagaraSimStageExecuteBehavior ExecuteBehavior;
	///<summary>Disables the ability to read / write from the same particle buffer, i.e. only update position and no other attributes.</summary>
	public bool bDisablePartialParticleUpdate;
	///<summary>Source data interface to use for the simulation stage. The data interface needs to be a subclass of UNiagaraDataInterfaceRWBase, for example the Grid2D and Grid3D data interfaces.</summary>
	public FNiagaraVariableDataInterfaceBinding DataInterface;
	///<summary>When enabled we iterate over the subset of particles that satisfy the binding &amp; range selected.</summary>
	public bool bParticleIterationStateEnabled;
	///<summary>Particle state attribute binding, when enabled we will only allow particles who pass the state range check to be processed.</summary>
	public FNiagaraVariableAttributeBinding ParticleIterationStateBinding;
	///<summary>The inclusive range used to check particle state binding against when enabled.</summary>
	public FIntPoint ParticleIterationStateRange;
	///<summary>When enabled we force the dispatch to be linear (i.e. one dimension is used).</summary>
	public bool bGpuDispatchForceLinear;
	///<summary>When enabled we use a custom number of threads for the dispatch.</summary>
	public bool bOverrideGpuDispatchNumThreads;
	///<summary>Parameter binding / constant value for Num Threads X</summary>
	public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsX;
	///<summary>Parameter binding / constant value for Num Threads Y</summary>
	public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsY;
	///<summary>Parameter binding / constant value for Num Threads Z</summary>
	public FNiagaraParameterBindingWithValue OverrideGpuDispatchNumThreadsZ;
	///<summary>Dimensions to use for dispatch.</summary>
	public ENiagaraGpuDispatchType DirectDispatchType;
	///<summary>Customizes what the element count means for a direct dispatch.</summary>
	public ENiagaraDirectDispatchElementType DirectDispatchElementType;
	///<summary>Integer binding to override the number of elements the stage will execute along X.</summary>
	public FNiagaraParameterBindingWithValue ElementCountX;
	///<summary>Integer binding to override the number of elements the stage will execute along Y.</summary>
	public FNiagaraParameterBindingWithValue ElementCountY;
	///<summary>Integer binding to override the number of elements the stage will execute along Z.</summary>
	public FNiagaraParameterBindingWithValue ElementCountZ;
	///<summary>Deprecated Properties</summary>
	public FNiagaraVariableAttributeBinding ElementCountBinding_DEPRECATED;
	///<summary>ElementCountXBinding_DEPRECATED</summary>
	public FNiagaraVariableAttributeBinding ElementCountXBinding_DEPRECATED;
	///<summary>ElementCountYBinding_DEPRECATED</summary>
	public FNiagaraVariableAttributeBinding ElementCountYBinding_DEPRECATED;
	///<summary>ElementCountZBinding_DEPRECATED</summary>
	public FNiagaraVariableAttributeBinding ElementCountZBinding_DEPRECATED;
	///<summary>bSpawnOnly_DEPRECATED</summary>
	public bool bSpawnOnly_DEPRECATED;
	///<summary>bOverrideGpuDispatchType_DEPRECATED</summary>
	public bool bOverrideGpuDispatchType_DEPRECATED;
	///<summary>OverrideGpuDispatchType_DEPRECATED</summary>
	public ENiagaraGpuDispatchType OverrideGpuDispatchType_DEPRECATED;
	///<summary>Iterations_DEPRECATED</summary>
	public int Iterations_DEPRECATED;
	///<summary>NumIterationsBinding_DEPRECATED</summary>
	public FNiagaraVariableAttributeBinding NumIterationsBinding_DEPRECATED;
	///<summary>OverrideGpuDispatchNumThreads_DEPRECATED</summary>
	public FIntVector OverrideGpuDispatchNumThreads_DEPRECATED;
}
