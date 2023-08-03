#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MRMeshComponent.h")]
public partial class UMRMeshComponent : UPrimitiveComponent {
	public static UClass StaticClass() {return default;}
	///<summary>IsConnected</summary>
	public  bool IsConnected() { return default; }
	///<summary>Force navmesh generation to run using the current collision data.  This will run even if the collision data has not been udpated! Unless you are changing navmesh settings or similar RequestNavMeshUpdate is reccomended.</summary>
	public  void ForceNavMeshUpdate() {}
	///<summary>Generate nav mesh if collision data has changed since the last nav mesh generation.</summary>
	public  void RequestNavMeshUpdate() {}
	///<summary>Clear</summary>
	public  void Clear() {}
	///<summary>Set the wireframe material.</summary>
	public  void SetWireframeMaterial(UMaterialInterface InMaterial) {}
	///<summary>SetEnableMeshOcclusion</summary>
	public  void SetEnableMeshOcclusion(bool bEnable) {}
	///<summary>GetEnableMeshOcclusion</summary>
	public  bool GetEnableMeshOcclusion() { return default; }
	///<summary>SetUseWireframe</summary>
	public  void SetUseWireframe(bool bUseWireframe) {}
	///<summary>GetUseWireframe</summary>
	public  bool GetUseWireframe() { return default; }
	///<summary>SetWireframeColor</summary>
	public  void SetWireframeColor(FLinearColor InColor) {}
	///<summary>GetWireframeColor</summary>
	public  FLinearColor GetWireframeColor() { return default; }
	///<summary>Material</summary>
	public UMaterialInterface Material;
	///<summary>WireframeMaterial</summary>
	public UMaterialInterface WireframeMaterial;
	///<summary>If true, MRMesh will create a renderable mesh proxy.  If false it will not, but could still provide collision.</summary>
	public bool bCreateMeshProxySections;
	///<summary>If true, MRMesh will automatically update its navmesh whenever any Mesh section is updated. This may be expensive. If this is disabled use ForceNavMeshUpdate to trigger a navmesh update when necessary.  Moving the component will also trigger a navmesh update.</summary>
	public bool bUpdateNavMeshOnMeshUpdate;
	///<summary>If true, MRMesh will not create a collidable ridgid body for each mesh section and can therefore never have collision.  Avoids the cost of generating collision.</summary>
	public bool bNeverCreateCollisionMesh;
	///<summary>Collision/Physics data</summary>
	public TArray<UMRMeshBodyHolder> BodyHolders;
}
