namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/FleshActor.h")]
public partial class AFleshActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>EnableSimulation</summary>
	public void EnableSimulation(ADeformableSolverActor Actor) {}
	///<summary>FleshComponent</summary>
	public UFleshComponent FleshComponent;
	///<summary>PrimarySolver</summary>
	public ADeformableSolverActor PrimarySolver;
}
