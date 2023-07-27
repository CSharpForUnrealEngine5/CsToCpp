#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("DataInterface/NiagaraDataInterfaceStaticMesh.h")]
///<summary>Data Interface allowing sampling of static meshes.</summary>
public partial class UNiagaraDataInterfaceStaticMesh : UNiagaraDataInterface {
// NiagaraDataInterfaceStaticMesh
	public ENDIStaticMesh_SourceMode SourceMode;
	public TSoftObjectPtr<UStaticMesh> PreviewMesh;
	public UStaticMesh DefaultMesh;
	public TSoftObjectPtr<AActor> SoftSourceActor;
	public AActor Source_DEPRECATED;
	public UStaticMeshComponent SourceComponent;
	public FNDIStaticMeshSectionFilter SectionFilter;
	public bool bUsePhysicsBodyVelocity;
	public bool bAllowSamplingFromStreamingLODs;
	public int LODIndex;
	public FNiagaraUserParameterBinding LODIndexUserParameter;
	public TArray<string> FilteredSockets;
	public  void OnSourceEndPlay(AActor InSource,EEndPlayReason Reason) {}
}
