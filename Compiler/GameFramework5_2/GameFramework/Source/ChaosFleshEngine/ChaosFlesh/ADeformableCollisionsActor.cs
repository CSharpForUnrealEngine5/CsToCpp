#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableCollisionsActor.h")]
public partial class ADeformableCollisionsActor : AActor {
// DeformableCollisionsActor
	public void EnableSimulation(UObject Actor) {}
	public UDeformableCollisionsComponent DeformableCollisionsComponent;
	public ADeformableSolverActor PrimarySolver;
	public TArray<AStaticMeshActor> StaticCollisions;
}
