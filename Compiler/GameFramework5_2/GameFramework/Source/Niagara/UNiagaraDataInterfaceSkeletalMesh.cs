#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of skeletal meshes.</summary>
[CppInclude("NiagaraDataInterfaceSkeletalMesh.h")]
public partial class UNiagaraDataInterfaceSkeletalMesh : UNiagaraDataInterface {
	///<summary>Controls how to retrieve the Skeletal Mesh Component to attach to.</summary>
	public ENDISkeletalMesh_SourceMode SourceMode;
	///<summary>Mesh used to sample from when not overridden by a source actor from the scene. Only available in editor for previewing. This is removed in cooked builds.</summary>
	public TSoftObjectPtr<USkeletalMesh> PreviewMesh;
	///<summary>The source actor from which to sample. Takes precedence over the direct mesh. Note that this can only be set when used as a user variable on a component in the world.</summary>
	public TSoftObjectPtr<AActor> SoftSourceActor;
	///<summary>If defined, the supplied tags will be used to identify a valid component</summary>
	public TArray<string> ComponentTags;
	///<summary>Source_DEPRECATED</summary>
	public AActor Source_DEPRECATED;
	///<summary>The source component from which to sample. Takes precedence over the direct mesh. Not exposed to the user, only indirectly accessible from blueprints.</summary>
	public USkeletalMeshComponent SourceComponent;
	///<summary>Reference to a user parameter if we&#39;re reading one.</summary>
	public FNiagaraUserParameterBinding MeshUserParameter;
	///<summary>Selects which skinning mode to use, for most cases Skin On The Fly will cover your requirements, see individual tooltips for more information.</summary>
	public ENDISkeletalMesh_SkinningMode SkinningMode;
	///<summary>Sampling regions on the mesh from which to sample. Leave this empty to sample from the whole mesh.</summary>
	public TArray<string> SamplingRegions;
	///<summary>If no regions are specified, we&#39;ll sample the whole mesh at this LODIndex. -1 indicates to use the last LOD.</summary>
	public int WholeMeshLOD;
	///<summary>Set of filtered bones that can be used for sampling. Select from these with GetFilteredBoneAt and RandomFilteredBone.</summary>
	public TArray<string> FilteredBones;
	///<summary>Set of filtered sockets that can be used for sampling. Select from these with GetFilteredSocketAt and RandomFilteredSocket.</summary>
	public TArray<string> FilteredSockets;
	///<summary>Optionally remove a single bone from Random / Random Unfiltered access.</summary>
	public string ExcludeBoneName;
	///<summary>bExcludeBone</summary>
	public bool bExcludeBone;
	///<summary>UvSetIndex</summary>
	public int UvSetIndex;
	///<summary>When this option is disabled, we use the previous frame&#39;s data for the skeletal mesh and can often issue the simulation early. This greatly</summary>
	public bool bRequireCurrentFrameData;
	///<summary>OnSourceEndPlay</summary>
	public  void OnSourceEndPlay(AActor InSource,EEndPlayReason Reason) {}
}
