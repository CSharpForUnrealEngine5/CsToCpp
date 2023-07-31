#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>StaticMeshActor is an instance of a UStaticMesh in the world.</summary>
[CppInclude("Engine/StaticMeshActor.h")]
public partial class AStaticMeshActor : AActor {
	///<summary>StaticMeshComponent</summary>
	public UStaticMeshComponent StaticMeshComponent;
	///<summary>This static mesh should replicate movement. Automatically sets the RemoteRole and bReplicateMovement flags. Meant to be edited on placed actors (those other two properties are not)</summary>
	public bool bStaticMeshReplicateMovement;
	///<summary>NavigationGeometryGatheringMode</summary>
	public ENavDataGatheringMode NavigationGeometryGatheringMode;
	///<summary>Function to change mobility type</summary>
	public  void SetMobility(EComponentMobility InMobility) {}
}
