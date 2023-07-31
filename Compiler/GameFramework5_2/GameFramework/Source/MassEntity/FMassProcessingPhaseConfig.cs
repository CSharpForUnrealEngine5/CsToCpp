#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessingPhaseManager.h")]
public partial struct FMassProcessingPhaseConfig {
	public string PhaseName;
	public UClass PhaseGroupClass;
	public TArray<UMassProcessor> ProcessorCDOs;
	public UMassCompositeProcessor PhaseProcessor;
	public string Description;
}
