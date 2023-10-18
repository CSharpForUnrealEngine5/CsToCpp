namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Import a skeletal mesh asset into the cloth collection simulation and/or render mesh containers.</summary>
[CppInclude("ChaosClothAsset/SkeletalMeshImportNode.h")]
public partial struct FChaosClothAssetSkeletalMeshImportNode {
	public FManagedArrayCollection Collection;
	public USkeletalMesh SkeletalMesh;
	public int LODIndex;
	public int SectionIndex;
	public bool bImportSimMesh;
	public bool bImportRenderMesh;
	public int UVChannel;
	public FVector2f UVScale;
}
