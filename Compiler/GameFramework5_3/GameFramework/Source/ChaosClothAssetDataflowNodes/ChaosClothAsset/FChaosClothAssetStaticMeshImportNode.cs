namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import a static mesh asset into the cloth collection simulation and/or render mesh containers.</summary>
[CppInclude("ChaosClothAsset/StaticMeshImportNode.h")]
public partial struct FChaosClothAssetStaticMeshImportNode {
	public FManagedArrayCollection Collection;
	public UStaticMesh StaticMesh;
	public int LODIndex;
	public bool bImportSimMesh;
	public bool bImportRenderMesh;
	public int UVChannel;
	public FVector2f UVScale;
}
