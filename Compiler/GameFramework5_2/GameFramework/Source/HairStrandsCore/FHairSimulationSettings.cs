#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairSimulationSettings {
// HairSimulationSettings
	public bool bOverrideSettings;
	public FHairSimulationSetup SimulationSetup;
	public FHairSimulationSolver SolverSettings;
	public FHairSimulationForces ExternalForces;
	public FHairSimulationConstraints MaterialConstraints;
}
