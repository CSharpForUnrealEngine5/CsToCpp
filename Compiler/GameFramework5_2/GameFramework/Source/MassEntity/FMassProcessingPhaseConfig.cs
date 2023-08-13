namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MassProcessingPhaseManager.h")]
public partial struct FMassProcessingPhaseConfig {
	public string PhaseName;
	public UClass PhaseGroupClass;
	public TArray<UMassProcessor> ProcessorCDOs;
	public UMassCompositeProcessor PhaseProcessor;
	public FText Description;
}
