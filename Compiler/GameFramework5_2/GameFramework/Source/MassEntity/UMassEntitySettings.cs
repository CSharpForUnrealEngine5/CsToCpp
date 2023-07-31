#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements the settings for MassEntity plugin</summary>
[CppInclude("MassEntitySettings.h")]
public partial class UMassEntitySettings : UMassModuleSettings {
	///<summary>The name of the file to dump the processor dependency graph. T</summary>
	public string DumpDependencyGraphFileName;
	///<summary>Lets users configure processing phases including the composite processor class to be used as a container for the phases&#39; processors.</summary>
	public FMassProcessingPhaseConfig ProcessingPhasesConfig;
	///<summary>This list contains all the processors available in the given binary (including plugins). The contents are sorted by display name.</summary>
	public TArray<UMassProcessor> ProcessorCDOs;
}
