namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* A mesh instance is a description of a translated scene node that point on a translated mesh asset.</summary>
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial struct FInterchangeMeshInstance {
	public string MeshInstanceUid;
	public UInterchangeSceneNode LodGroupNode;
	public bool bReferenceSkinnedMesh;
	public bool bReferenceMorphTarget;
	public bool bHasMorphTargets;
	public TMap<int,FInterchangeLodSceneNodeContainer> SceneNodePerLodIndex;
	public TArray<string> ReferencingMeshGeometryUids;
}
