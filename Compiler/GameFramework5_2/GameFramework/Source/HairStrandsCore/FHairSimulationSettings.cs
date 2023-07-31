#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairSimulationSettings {
	public bool bOverrideSettings;
	public FHairSimulationSetup SimulationSetup;
	public FHairSimulationSolver SolverSettings;
	public FHairSimulationForces ExternalForces;
	public FHairSimulationConstraints MaterialConstraints;
}
