#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Data Interface for interacting with PhysicsAssets</summary>
[CppInclude("NiagaraDataInterfacePhysicsAsset.h")]
public partial class UNiagaraDataInterfacePhysicsAsset : UNiagaraDataInterface {
	///<summary>Skeletal Mesh from which the Physics Asset will be found.</summary>
	public UPhysicsAsset DefaultSource;
	///<summary>The source actor from which to sample</summary>
	public TSoftObjectPtr<AActor> SoftSourceActor;
	///<summary>SourceActor_DEPRECATED</summary>
	public AActor SourceActor_DEPRECATED;
	///<summary>Reference to a user parameter if we&#39;re reading one.</summary>
	public FNiagaraUserParameterBinding MeshUserParameter;
}
