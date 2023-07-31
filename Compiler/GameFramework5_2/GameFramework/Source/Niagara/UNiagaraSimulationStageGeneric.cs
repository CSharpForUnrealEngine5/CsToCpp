#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraSimulationStageBase.h")]
public partial class UNiagaraSimulationStageGeneric : UNiagaraSimulationStageBase {
	///<summary>Optional bool binding allowing scripts to control if the simulation stage is enabled or not.</summary>
	public FNiagaraVariableAttributeBinding EnabledBinding;
	///<summary>Select what we should be iterating over, particles or data interfaces.</summary>
	public ENiagaraIterationSource IterationSource;
	///<summary>Number of times (or iterations) the simulation stage will execute in a row.</summary>
	public int Iterations;
	///<summary>Optional integer binding allowing scripts to control the number of iterations.</summary>
	public FNiagaraVariableAttributeBinding NumIterationsBinding;
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
	///<summary>OverrideGpuDispatchNumThreads</summary>
	public FIntVector OverrideGpuDispatchNumThreads;
	///<summary>Dimensions to use for dispatch.</summary>
	public ENiagaraGpuDispatchType DirectDispatchType;
	///<summary>Customizes what the element count means for a direct dispatch.</summary>
	public ENiagaraDirectDispatchElementType DirectDispatchElementType;
	///<summary>Integer binding to override the number of elements the stage will execute along X.</summary>
	public FNiagaraVariableAttributeBinding ElementCountXBinding;
	///<summary>Integer binding to override the number of elements the stage will execute along Y.</summary>
	public FNiagaraVariableAttributeBinding ElementCountYBinding;
	///<summary>Integer binding to override the number of elements the stage will execute along Z.</summary>
	public FNiagaraVariableAttributeBinding ElementCountZBinding;
	///<summary>Deprecated Properties</summary>
	public FNiagaraVariableAttributeBinding ElementCountBinding_DEPRECATED;
	///<summary>bSpawnOnly_DEPRECATED</summary>
	public bool bSpawnOnly_DEPRECATED;
	///<summary>bOverrideGpuDispatchType_DEPRECATED</summary>
	public bool bOverrideGpuDispatchType_DEPRECATED;
	///<summary>OverrideGpuDispatchType_DEPRECATED</summary>
	public ENiagaraGpuDispatchType OverrideGpuDispatchType_DEPRECATED;
}
