namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Reverse the geometry&#39;s normals or/and winding order of the simulation or/and render meshes stored in the cloth collection.</summary>
[CppInclude("ChaosClothAsset/ReverseNormalsNode.h")]
public partial struct FChaosClothAssetReverseNormalsNode {
	public FManagedArrayCollection Collection;
	public TArray<int> SimPatterns;
	public bool bReverseSimMeshNormals;
	public bool bReverseSimMeshWindingOrder;
	public TArray<int> RenderPatterns;
	public bool bReverseRenderMeshNormals;
	public bool bReverseRenderMeshWindingOrder;
}
