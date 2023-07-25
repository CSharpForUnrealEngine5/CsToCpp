#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfaceSkeletalMesh.h")]
///<summary>Data Interface allowing sampling of skeletal meshes.</summary>
public partial class UNiagaraDataInterfaceSkeletalMesh : UNiagaraDataInterface {
// NiagaraDataInterfaceSkeletalMesh
	public ENDISkeletalMesh_SourceMode SourceMode;
	public TSoftObjectPtr<USkeletalMesh> PreviewMesh;
	public TSoftObjectPtr<AActor> SoftSourceActor;
	public TArray<string> ComponentTags;
	public AActor Source_DEPRECATED;
	public USkeletalMeshComponent SourceComponent;
	public FNiagaraUserParameterBinding MeshUserParameter;
	public ENDISkeletalMesh_SkinningMode SkinningMode;
	public TArray<string> SamplingRegions;
	public int WholeMeshLOD;
	public TArray<string> FilteredBones;
	public TArray<string> FilteredSockets;
	public string ExcludeBoneName;
	public bool bExcludeBone;
	public int UvSetIndex;
	public bool bRequireCurrentFrameData;
	public void OnSourceEndPlay(UObject InSource,EEndPlayReason Reason) {}
}
