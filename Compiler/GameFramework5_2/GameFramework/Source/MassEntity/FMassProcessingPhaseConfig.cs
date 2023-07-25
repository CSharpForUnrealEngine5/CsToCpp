#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessingPhaseManager.h")]
public partial struct FMassProcessingPhaseConfig {
// MassProcessingPhaseConfig
	public string PhaseName;
	public UClass PhaseGroupClass;
	public TArray<UMassProcessor> ProcessorCDOs;
	public UMassCompositeProcessor PhaseProcessor;
	public string Description;
}
