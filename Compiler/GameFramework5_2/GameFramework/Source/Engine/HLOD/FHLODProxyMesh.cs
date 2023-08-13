namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A mesh proxy entry</summary>
[CppInclude("HLOD/HLODProxyMesh.h")]
public partial struct FHLODProxyMesh {
	public TLazyObjectPtr<ALODActor> LODActor;
	public UStaticMesh StaticMesh;
	public string Key;
}
