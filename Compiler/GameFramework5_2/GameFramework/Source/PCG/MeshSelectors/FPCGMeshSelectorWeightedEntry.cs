namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MeshSelectors/PCGMeshSelectorWeighted.h")]
public partial struct FPCGMeshSelectorWeightedEntry {
	public FSoftISMComponentDescriptor Descriptor;
	public int Weight;
	public TSoftObjectPtr<UStaticMesh> Mesh_DEPRECATED;
	public bool bOverrideCollisionProfile_DEPRECATED;
	public FCollisionProfileName CollisionProfile_DEPRECATED;
	public bool bOverrideMaterials_DEPRECATED;
	public TArray<TSoftObjectPtr<UMaterialInterface>> MaterialOverrides_DEPRECATED;
	public float CullStartDistance_DEPRECATED;
	public float CullEndDistance_DEPRECATED;
	public int WorldPositionOffsetDisableDistance_DEPRECATED;
}
