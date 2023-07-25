#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAssetPhysics.h")]
public partial struct FHairSolverSettings {
// HairSolverSettings
	public bool EnableSimulation;
	public EGroomNiagaraSolvers NiagaraSolver;
	public TSoftObjectPtr<UNiagaraSystem> CustomSystem;
	public float GravityPreloading;
	public int SubSteps;
	public int IterationCount;
}
