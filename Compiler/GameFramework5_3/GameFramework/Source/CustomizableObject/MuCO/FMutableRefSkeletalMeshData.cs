namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MuCO/CustomizableObject.h")]
public partial struct FMutableRefSkeletalMeshData {
	public USkeletalMesh SkeletalMesh;
	public FSoftObjectPath SkeletalMeshAssetPath;
	public TArray<FMutableRefLODData> LODData;
	public TArray<FMutableRefSocket> Sockets;
	public FBoxSphereBounds Bounds;
	public FMutableRefSkeletalMeshSettings Settings;
	public TSoftObjectPtr<USkeleton> Skeleton;
	public TSoftObjectPtr<UPhysicsAsset> PhysicsAsset;
	public TSoftObjectPtr<UClass> PostProcessAnimInst;
	public TSoftObjectPtr<UPhysicsAsset> ShadowPhysicsAsset;
	public TArray<FMutableRefAssetUserData> AssetUserData;
}
