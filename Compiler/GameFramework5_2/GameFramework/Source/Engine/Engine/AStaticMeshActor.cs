#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/StaticMeshActor.h")]
///<summary>StaticMeshActor is an instance of a UStaticMesh in the world.</summary>
public partial class AStaticMeshActor : AActor {
// StaticMeshActor
	public UStaticMeshComponent StaticMeshComponent;
	public bool bStaticMeshReplicateMovement;
	public ENavDataGatheringMode NavigationGeometryGatheringMode;
	public  void SetMobility(EComponentMobility InMobility) {}
}
