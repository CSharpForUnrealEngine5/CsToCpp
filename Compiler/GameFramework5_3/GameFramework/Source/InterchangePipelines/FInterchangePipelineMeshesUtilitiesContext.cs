namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>* Represent the context UInterchangePipelineMeshesUtilities will use when client query the data</summary>
[CppInclude("InterchangePipelineMeshesUtilities.h")]
public partial struct FInterchangePipelineMeshesUtilitiesContext {
	public bool bConvertStaticMeshToSkeletalMesh;
	public bool bConvertSkeletalMeshToStaticMesh;
	public bool bConvertStaticsWithMorphTargetsToSkeletals;
	public bool bImportMeshesInBoneHierarchy;
	public bool bQueryGeometryOnlyIfNoInstance;
}
