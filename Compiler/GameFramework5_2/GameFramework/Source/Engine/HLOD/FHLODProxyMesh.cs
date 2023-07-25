#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("HLOD/HLODProxyMesh.h")]
///<summary>A mesh proxy entry</summary>
public partial struct FHLODProxyMesh {
// HLODProxyMesh
	public TLazyObjectPtr<ALODActor> LODActor;
	public UStaticMesh StaticMesh;
	public string Key;
}
