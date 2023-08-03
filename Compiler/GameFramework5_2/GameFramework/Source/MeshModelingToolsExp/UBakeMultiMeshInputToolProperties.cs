#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("BakeMultiMeshAttributeMapsTool.h")]
public partial class UBakeMultiMeshInputToolProperties : UInteractiveToolPropertySet {
	public static UClass StaticClass() {return default;}
	///<summary>Target mesh to sample to</summary>
	public UStaticMesh TargetStaticMesh;
	///<summary>Target mesh to sample to</summary>
	public USkeletalMesh TargetSkeletalMesh;
	///<summary>Target mesh to sample to</summary>
	public AActor TargetDynamicMesh;
	///<summary>UV channel to use for the target mesh</summary>
	public string TargetUVLayer;
	///<summary>Source meshes and textures to sample from</summary>
	public TArray<FBakeMultiMeshDetailProperties> SourceMeshes;
	///<summary>Maximum allowed distance for the projection from target mesh to source mesh for the sample to be considered valid.</summary>
	public float ProjectionDistance;
	///<summary>GetTargetUVLayerNamesFunc</summary>
	public  TArray<string> GetTargetUVLayerNamesFunc() { return default; }
	///<summary>TargetUVLayerNamesList</summary>
	public TArray<string> TargetUVLayerNamesList;
}
