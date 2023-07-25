#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessor.h")]
public partial class UMassProcessor : UObject {
// MassProcessor
	public int ExecutionFlags;
	public EMassProcessingPhase ProcessingPhase;
	public FMassProcessorExecutionOrder ExecutionOrder;
	public bool bAutoRegisterWithProcessingPhases;
	public bool bRequiresGameThreadExecution;
	public bool bCanShowUpInSettings;
}
