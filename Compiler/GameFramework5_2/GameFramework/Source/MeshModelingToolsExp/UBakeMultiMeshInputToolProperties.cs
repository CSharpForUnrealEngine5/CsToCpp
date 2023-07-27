#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshInputToolProperties : UInteractiveToolPropertySet {
// BakeMultiMeshInputToolProperties
	public UStaticMesh TargetStaticMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public AActor TargetDynamicMesh;
	public string TargetUVLayer;
	public TArray<FBakeMultiMeshDetailProperties> SourceMeshes;
	public float ProjectionDistance;
	public  TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	public TArray<string> TargetUVLayerNamesList;
}
