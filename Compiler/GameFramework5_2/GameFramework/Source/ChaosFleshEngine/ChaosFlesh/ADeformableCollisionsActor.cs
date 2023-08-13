namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosFlesh/ChaosDeformableCollisionsActor.h")]
public partial class ADeformableCollisionsActor : AActor {
	public static UClass StaticClass() {return default;}
	///<summary>EnableSimulation</summary>
	public void EnableSimulation(ADeformableSolverActor Actor) {}
	///<summary>DeformableCollisionsComponent</summary>
	public UDeformableCollisionsComponent DeformableCollisionsComponent;
	///<summary>PrimarySolver</summary>
	public ADeformableSolverActor PrimarySolver;
	///<summary>StaticCollisions</summary>
	public TArray<AStaticMeshActor> StaticCollisions;
}
