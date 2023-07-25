#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableSolverComponent.h")]
///<summary>UDeformableSolverComponent</summary>
public partial class UDeformableSolverComponent : USceneComponent {
// DeformableSolverComponent
	public FConnectedObjectsGroup ConnectedObjects;
	public FSolverTimingGroup SolverTiming;
	public FSolverEvolutionGroup SolverEvolution;
	public FSolverCollisionsGroup SolverCollisions;
	public FSolverConstraintsGroup SolverConstraints;
	public FSolverForcesGroup SolverForces;
	public FSolverDebuggingGroup SolverDebugging;
}
