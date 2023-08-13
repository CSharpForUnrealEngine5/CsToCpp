namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial class UMassProcessor : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Whether this processor should be executed on StandAlone or Server or Client</summary>
	public int ExecutionFlags;
	///<summary>Processing phase this processor will be automatically run as part of.</summary>
	public EMassProcessingPhase ProcessingPhase;
	///<summary>Configures when this given processor can be executed in relation to other processors and processing groups, within its processing phase.</summary>
	public FMassProcessorExecutionOrder ExecutionOrder;
	///<summary>Configures whether this processor should be automatically included in the global list of processors executed every tick (see ProcessingPhase and ExecutionOrder).</summary>
	public bool bAutoRegisterWithProcessingPhases;
	///<summary>bRequiresGameThreadExecution</summary>
	public bool bRequiresGameThreadExecution;
	///<summary>Used to permanently remove a given processor class from PipeSetting&#39;s listing. Used primarily for test-time</summary>
	public bool bCanShowUpInSettings;
}
