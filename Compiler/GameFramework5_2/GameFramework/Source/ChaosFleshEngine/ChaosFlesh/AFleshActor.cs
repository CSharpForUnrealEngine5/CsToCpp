#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/FleshActor.h")]
public partial class AFleshActor : AActor {
// FleshActor
	public  void EnableSimulation(ADeformableSolverActor Actor) {}
	public UFleshComponent FleshComponent;
	public ADeformableSolverActor PrimarySolver;
}
