#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("NiagaraDataInterfacePhysicsAsset.h")]
///<summary>Data Interface for interacting with PhysicsAssets</summary>
public partial class UNiagaraDataInterfacePhysicsAsset : UNiagaraDataInterface {
// NiagaraDataInterfacePhysicsAsset
	public UPhysicsAsset DefaultSource;
	public TSoftObjectPtr<AActor> SoftSourceActor;
	public AActor SourceActor_DEPRECATED;
	public FNiagaraUserParameterBinding MeshUserParameter;
}
