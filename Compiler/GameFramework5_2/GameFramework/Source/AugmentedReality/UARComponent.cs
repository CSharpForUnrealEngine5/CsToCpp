#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ARComponent.h")]
///<summary>ARComponent handles replication and visualization update for AR tracked geometries</summary>
public partial class UARComponent : USceneComponent {
// ARComponent
	public  void SetNativeID(FGuid NativeID) {}
	public  UMRMeshComponent GetMRMesh() { return default; }
	public  void ReceiveRemove() {}
	public  void UpdateVisualization() {}
	public FGuid NativeID;
	public  void OnRep_Payload() {}
	public bool bUseDefaultReplication;
	public UMaterialInterface DefaultMeshMaterial;
	public UMaterialInterface DefaultWireframeMeshMaterial;
	public UMRMeshComponent MRMeshComponent;
	public UARTrackedGeometry MyTrackedGeometry;
}
