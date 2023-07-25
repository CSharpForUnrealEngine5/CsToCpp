#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ChaosClothAsset/ClothAsset.h")]
///<summary>Cloth asset for pattern based simulation.</summary>
public partial class UChaosClothAsset : USkinnedAsset {
// ChaosClothAsset
	public UObject GetShadowPhysicsAsset() { return default; }
	public UDataflow DataflowAsset;
	public string DataflowTerminal;
	public TArray<FSkeletalMaterial> Materials;
	public UPhysicsAsset PhysicsAsset;
	public TArray<FSkeletalMeshLODInfo> LODInfo;
	public FPerPlatformBool DisableBelowMinLodStripping;
	public FPerPlatformInt MinLod;
	public bool bSupportRayTracing;
	public int RayTracingMinLOD;
	public bool bSmoothTransition;
	public bool bUseMultipleInfluences;
	public float SkinningKernelRadius;
	public UPhysicsAsset ShadowPhysicsAsset;
	public FGuid AssetGuid;
}
