#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface allowing sampling of static meshes.</summary>
[CppInclude("DataInterface/NiagaraDataInterfaceStaticMesh.h")]
public partial class UNiagaraDataInterfaceStaticMesh : UNiagaraDataInterface {
	///<summary>Controls how to retrieve the Static Mesh Component to attach to.</summary>
	public ENDIStaticMesh_SourceMode SourceMode;
	///<summary>Mesh used to sample from when not overridden by a source actor from the scene. Only available in editor for previewing. This is removed in cooked builds.</summary>
	public TSoftObjectPtr<UStaticMesh> PreviewMesh;
	///<summary>Mesh used to sample from when not overridden by a source actor from the scene. This mesh is NOT removed from cooked builds.</summary>
	public UStaticMesh DefaultMesh;
	///<summary>The source actor from which to sample. Takes precedence over the direct mesh. Note that this can only be set when used as a user variable on a component in the world.</summary>
	public TSoftObjectPtr<AActor> SoftSourceActor;
	///<summary>Source_DEPRECATED</summary>
	public AActor Source_DEPRECATED;
	///<summary>The source component from which to sample. Takes precedence over the direct mesh. Not exposed to the user, only indirectly accessible from blueprints.</summary>
	public UStaticMeshComponent SourceComponent;
	///<summary>Array of filters the can be used to limit sampling to certain sections of the mesh.</summary>
	public FNDIStaticMeshSectionFilter SectionFilter;
	///<summary>If true then the mesh velocity is taken from the mesh component&#39;s physics data. Otherwise it will be calculated by diffing the component transforms between ticks, which is more reliable but won&#39;t work on the first frame.</summary>
	public bool bUsePhysicsBodyVelocity;
	///<summary>When true, we allow this DI to sample from streaming LODs. Selectively overriding the CVar fx.Niagara.NDIStaticMesh.UseInlineLODsOnly.</summary>
	public bool bAllowSamplingFromStreamingLODs;
	///<summary>Static Mesh LOD to sample.</summary>
	public int LODIndex;
	///<summary>Reference to a user parameter if we&#39;re reading one.</summary>
	public FNiagaraUserParameterBinding LODIndexUserParameter;
	///<summary>List of filtered sockets to use.</summary>
	public TArray<string> FilteredSockets;
	///<summary>OnSourceEndPlay</summary>
	public  void OnSourceEndPlay(AActor InSource,EEndPlayReason Reason) {}
}
