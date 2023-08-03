#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>ARComponent handles replication and visualization update for AR tracked geometries</summary>
[CppInclude("ARComponent.h")]
public partial class UARComponent : USceneComponent {
	public static UClass StaticClass() {return default;}
	///<summary>SetNativeID</summary>
	public  void SetNativeID(FGuid NativeID) {}
	///<summary>GetMRMesh</summary>
	public  UMRMeshComponent GetMRMesh() { return default; }
	///<summary>Event when native representation is removed, called on server and clients.</summary>
	public  void ReceiveRemove() {}
	///<summary>UpdateVisualization</summary>
	public  void UpdateVisualization() {}
	///<summary>NativeID</summary>
	public FGuid NativeID;
	///<summary>OnRep_Payload</summary>
	public  void OnRep_Payload() {}
	///<summary>If the default replication logic should be used for this component</summary>
	public bool bUseDefaultReplication;
	///<summary>The default material to be used for the generated mesh component.</summary>
	public UMaterialInterface DefaultMeshMaterial;
	///<summary>The default wireframe material to be used for the generated mesh component.</summary>
	public UMaterialInterface DefaultWireframeMeshMaterial;
	///<summary>MRMeshComponent</summary>
	public UMRMeshComponent MRMeshComponent;
	///<summary>The tracked geometry used for updating this component, only set on &quot;local&quot; client</summary>
	public UARTrackedGeometry MyTrackedGeometry;
}
