#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformableSolverComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformableSolverComponent.h")]
public partial class UDeformableSolverComponent : USceneComponent {
	///<summary>Properties : Do NOT place ungrouped properties in this class</summary>
	public FConnectedObjectsGroup ConnectedObjects;
	///<summary>SolverTiming</summary>
	public FSolverTimingGroup SolverTiming;
	///<summary>SolverEvolution</summary>
	public FSolverEvolutionGroup SolverEvolution;
	///<summary>SolverCollisions</summary>
	public FSolverCollisionsGroup SolverCollisions;
	///<summary>SolverConstraints</summary>
	public FSolverConstraintsGroup SolverConstraints;
	///<summary>SolverForces</summary>
	public FSolverForcesGroup SolverForces;
	///<summary>SolverDebugging</summary>
	public FSolverDebuggingGroup SolverDebugging;
}
