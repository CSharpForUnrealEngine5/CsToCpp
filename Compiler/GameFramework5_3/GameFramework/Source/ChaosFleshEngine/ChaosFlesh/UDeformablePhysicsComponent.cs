namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDeformablePhysicsComponent</summary>
[CppInclude("ChaosFlesh/ChaosDeformablePhysicsComponent.h")]
public partial class UDeformablePhysicsComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>EnableSimulation</summary>
	public void EnableSimulation(UDeformableSolverComponent DeformableSolverComponent) {}
	///<summary>EnableSimulationFromActor</summary>
	public void EnableSimulationFromActor(ADeformableSolverActor DeformableSolverActor) {}
	///<summary>PrimarySolverComponent</summary>
	public UDeformableSolverComponent PrimarySolverComponent;
}
