#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformablePhysicsComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformablePhysicsComponent.h")]
public partial class UDeformablePhysicsComponent : UPrimitiveComponent {
	///<summary>EnableSimulation</summary>
	public  void EnableSimulation(UDeformableSolverComponent DeformableSolverComponent) {}
	///<summary>EnableSimulationFromActor</summary>
	public  void EnableSimulationFromActor(ADeformableSolverActor DeformableSolverActor) {}
	///<summary>PrimarySolverComponent</summary>
	public UDeformableSolverComponent PrimarySolverComponent;
}
