#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMeshAttributeToolCommon.h")]
public partial class UBakeInputMeshProperties : UInteractiveToolPropertySet {
// BakeInputMeshProperties
	public UStaticMesh TargetStaticMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public AActor TargetDynamicMesh;
	public string TargetUVLayer;
	public bool bHasTargetUVLayer;
	public UStaticMesh SourceStaticMesh;
	public USkeletalMesh SourceSkeletalMesh;
	public AActor SourceDynamicMesh;
	public bool bHideSourceMesh;
	public UTexture2D SourceNormalMap;
	public string SourceNormalMapUVLayer;
	public EBakeNormalSpace SourceNormalSpace;
	public bool bHasSourceNormalMap;
	public float ProjectionDistance;
	public bool bProjectionInWorldSpace;
	public  TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	public TArray<string> TargetUVLayerNamesList;
	public  TArray<string> GetSourceUVLayerNamesFunc() { return default; }
	public TArray<string> SourceUVLayerNamesList;
}
