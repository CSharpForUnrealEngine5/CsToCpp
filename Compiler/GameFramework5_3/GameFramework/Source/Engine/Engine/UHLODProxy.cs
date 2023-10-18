namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This asset acts as a proxy to a static mesh for ALODActors to display</summary>
[CppInclude("Engine/HLODProxy.h")]
public partial class UHLODProxy : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Keep hold of the level in the editor to allow for package cleaning etc.</summary>
	public TSoftObjectPtr<UWorld> OwningMap;
	///<summary>All the mesh proxies we contain</summary>
	public TArray<FHLODProxyMesh> ProxyMeshes;
	///<summary>HLODActors</summary>
	public TMap<UHLODProxyDesc,FHLODProxyMesh> HLODActors;
}
