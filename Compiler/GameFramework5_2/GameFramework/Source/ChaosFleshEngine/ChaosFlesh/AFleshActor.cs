#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/FleshActor.h")]
public partial class AFleshActor : AActor {
	///<summary>EnableSimulation</summary>
	public  void EnableSimulation(ADeformableSolverActor Actor) {}
	///<summary>FleshComponent</summary>
	public UFleshComponent FleshComponent;
	///<summary>PrimarySolver</summary>
	public ADeformableSolverActor PrimarySolver;
}
