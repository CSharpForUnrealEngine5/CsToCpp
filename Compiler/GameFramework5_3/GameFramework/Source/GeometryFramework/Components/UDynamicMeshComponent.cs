namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>UDynamicMeshComponent is a mesh component similar to UProceduralMeshComponent,</summary>
[CppInclude("Components/DynamicMeshComponent.h")]
public partial class UDynamicMeshComponent : UBaseDynamicMeshComponent {
	public static UClass StaticClass() {return default;}
	///<summary>Replace the current UDynamicMesh with a new one, and transfer ownership of NewMesh to this Component.</summary>
	public void SetDynamicMesh(UDynamicMesh NewMesh) {}
	///<summary>Internal FDynamicMesh is stored inside a UDynamicMesh container, which allows it to be</summary>
	public UDynamicMesh MeshObject;
	///<summary>Notify the Component that it&#39;s DynamicMesh has been modified externally. This will result in all Rendering Data</summary>
	public virtual void NotifyMeshModified() {}
	///<summary>Notify the Component that vertex attribute values of it&#39;s DynamicMesh have been modified externally. This will result in</summary>
	public virtual void NotifyMeshVertexAttributesModified(bool bPositions/*=true*/,bool bNormals/*=true*/,bool bUVs/*=true*/,bool bColors/*=true*/) {}
	///<summary>Set new list of Materials for the Mesh. Dynamic Mesh Component does not have</summary>
	public void ConfigureMaterialSet(TArray<UMaterialInterface> NewMaterialSet) {}
	///<summary>Compute the maximum MaterialID on the DynamicMesh, and ensure that Material Slots match.</summary>
	public bool ValidateMaterialSlots(bool bCreateIfMissing/*=true*/,bool bDeleteExtraSlots/*=true*/) { return default; }
	///<summary>SetTangentsType</summary>
	public void SetTangentsType(EDynamicMeshComponentTangentsMode NewTangentsType) {}
	///<summary>GetTangentsType</summary>
	public EDynamicMeshComponentTangentsMode GetTangentsType() { return default; }
	///<summary>pure version of GetTangentsType, so it can be used as a getter below (getters must be BlueprintPure)</summary>
	public EDynamicMeshComponentTangentsMode GetTangentsTypePure() { return default; }
	///<summary>Tangent source defines whether we use the provided tangents on the Dynamic Mesh, autogenerate tangents, or do not use tangents</summary>
	public EDynamicMeshComponentTangentsMode TangentsType;
	///<summary>calls SetComplexAsSimpleCollisionEnabled(true, true)</summary>
	public void EnableComplexAsSimpleCollision() {}
	///<summary>If bEnabled=true, sets bEnableComplexCollision=true and CollisionType=CTF_UseComplexAsSimple</summary>
	public void SetComplexAsSimpleCollisionEnabled(bool bEnabled,bool bImmediateUpdate/*=true*/) {}
	///<summary>Set value of bDeferCollisionUpdates, when enabled, collision is not automatically recomputed each time the mesh changes.</summary>
	public void SetDeferredCollisionUpdatesEnabled(bool bEnabled,bool bImmediateUpdate/*=true*/) {}
	///<summary>Force an update of the Collision/Physics data for this Component.</summary>
	public virtual void UpdateCollision(bool bOnlyIfPending/*=true*/) {}
	///<summary>Type of Collision Geometry to use for this Mesh</summary>
	public ECollisionTraceFlag CollisionType;
	///<summary>Controls whether the physics cooking should be done off the game thread.</summary>
	public bool bUseAsyncCooking;
	///<summary>If true, current mesh will be used as Complex Collision source mesh.</summary>
	public bool bEnableComplexCollision;
	///<summary>If true, updates to the mesh will not result in immediate collision regeneration. Useful when the mesh will be modified multiple times before collision is needed.</summary>
	public bool bDeferCollisionUpdates;
	///<summary>MeshBodySetup</summary>
	public UBodySetup MeshBodySetup;
	///<summary>Simplified collision representation for the mesh component</summary>
	public FKAggregateGeom AggGeom;
	///<summary>Queue for async body setups that are being cooked</summary>
	public TArray<UBodySetup> AsyncBodySetupQueue;
}
