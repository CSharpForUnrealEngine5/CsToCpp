#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableCollisionsActor.h")]
public partial class ADeformableCollisionsActor : AActor {
	///<summary>EnableSimulation</summary>
	public  void EnableSimulation(ADeformableSolverActor Actor) {}
	///<summary>DeformableCollisionsComponent</summary>
	public UDeformableCollisionsComponent DeformableCollisionsComponent;
	///<summary>PrimarySolver</summary>
	public ADeformableSolverActor PrimarySolver;
	///<summary>StaticCollisions</summary>
	public TArray<AStaticMeshActor> StaticCollisions;
}
