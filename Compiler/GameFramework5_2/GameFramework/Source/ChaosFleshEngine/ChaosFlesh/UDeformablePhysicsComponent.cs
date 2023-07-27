#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformablePhysicsComponent.h")]
///<summary>UDeformablePhysicsComponent</summary>
public partial class UDeformablePhysicsComponent : UPrimitiveComponent {
// DeformablePhysicsComponent
	public  void EnableSimulation(UDeformableSolverComponent DeformableSolverComponent) {}
	public  void EnableSimulationFromActor(ADeformableSolverActor DeformableSolverActor) {}
	public UDeformableSolverComponent PrimarySolverComponent;
}
