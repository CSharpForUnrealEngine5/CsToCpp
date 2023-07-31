#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeInputMeshProperties : UInteractiveToolPropertySet {
	///<summary>Target mesh to sample to</summary>
	public UStaticMesh TargetStaticMesh;
	///<summary>Target mesh to sample to</summary>
	public USkeletalMesh TargetSkeletalMesh;
	///<summary>Target mesh to sample to</summary>
	public AActor TargetDynamicMesh;
	///<summary>UV channel to use for the target mesh</summary>
	public string TargetUVLayer;
	///<summary>If true, expose the TargetUVLayer property</summary>
	public bool bHasTargetUVLayer;
	///<summary>Source mesh to sample from</summary>
	public UStaticMesh SourceStaticMesh;
	///<summary>Source mesh to sample from</summary>
	public USkeletalMesh SourceSkeletalMesh;
	///<summary>Source mesh to sample from</summary>
	public AActor SourceDynamicMesh;
	///<summary>If true, hide the source mesh</summary>
	public bool bHideSourceMesh;
	///<summary>Source mesh normal map; if empty, the geometric normals will be used</summary>
	public UTexture2D SourceNormalMap;
	///<summary>UV channel to use for the source mesh normal map; only relevant if a source normal map is set</summary>
	public string SourceNormalMapUVLayer;
	///<summary>Normal space of the source mesh normal map.</summary>
	public EBakeNormalSpace SourceNormalSpace;
	///<summary>If true, expose the SourceNormalMap and SourceNormalMapUVLayer properties</summary>
	public bool bHasSourceNormalMap;
	///<summary>Maximum allowed distance for the projection from target mesh to source mesh for the sample to be considered valid.</summary>
	public float ProjectionDistance;
	///<summary>If true, uses the world space positions for the projection from target mesh to source mesh, otherwise it uses their object space positions.</summary>
	public bool bProjectionInWorldSpace;
	///<summary>GetTargetUVLayerNamesFunc</summary>
	public  TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	///<summary>TargetUVLayerNamesList</summary>
	public TArray<string> TargetUVLayerNamesList;
	///<summary>GetSourceUVLayerNamesFunc</summary>
	public  TArray<string> GetSourceUVLayerNamesFunc() { return default; }
	///<summary>SourceUVLayerNamesList</summary>
	public TArray<string> SourceUVLayerNamesList;
}
