#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("InterchangePipelineMeshesUtilities.h")]
///<summary>* A mesh instance is a description of a translated scene node that point on a translated mesh asset.</summary>
public partial struct FInterchangeMeshInstance {
// InterchangeMeshInstance
	public string MeshInstanceUid;
	public UInterchangeSceneNode LodGroupNode;
	public bool bReferenceSkinnedMesh;
	public bool bReferenceMorphTarget;
	public TMap<int,FInterchangeLodSceneNodeContainer> SceneNodePerLodIndex;
	public TArray<string> ReferencingMeshGeometryUids;
}
