#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Engine/HLODProxy.h")]
///<summary>This asset acts as a proxy to a static mesh for ALODActors to display</summary>
public partial class UHLODProxy : UObject {
// HLODProxy
	public TSoftObjectPtr<UWorld> OwningMap;
	public TArray<FHLODProxyMesh> ProxyMeshes;
	public TMap<UHLODProxyDesc,FHLODProxyMesh> HLODActors;
}
