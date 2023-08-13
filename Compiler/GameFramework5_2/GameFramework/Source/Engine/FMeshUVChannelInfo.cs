namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The world size for each texcoord mapping. Used by the texture streaming.</summary>
[CppInclude("MeshUVChannelInfo.h")]
public partial struct FMeshUVChannelInfo {
	public bool bInitialized;
	public bool bOverrideDensities;
	public float LocalUVDensities;
}
