#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformablePhysicsComponent.h")]
///<summary>UDeformablePhysicsComponent</summary>
public partial class UDeformablePhysicsComponent : UPrimitiveComponent {
// DeformablePhysicsComponent
	public void EnableSimulation(UObject DeformableSolverComponent) {}
	public void EnableSimulationFromActor(UObject DeformableSolverActor) {}
	public UDeformableSolverComponent PrimarySolverComponent;
}
