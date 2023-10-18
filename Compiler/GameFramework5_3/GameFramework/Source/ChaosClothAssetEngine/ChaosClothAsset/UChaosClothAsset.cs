namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Cloth asset for pattern based simulation.</summary>
[CppInclude("ChaosClothAsset/ClothAsset.h")]
public partial class UChaosClothAsset : USkinnedAsset {
	public static UClass StaticClass() {return default;}
	///<summary>GetShadowPhysicsAsset</summary>
	public virtual UPhysicsAsset GetShadowPhysicsAsset() { return default; }
	///<summary>DataflowAsset</summary>
	public UDataflow DataflowAsset;
	///<summary>DataflowTerminal</summary>
	public string DataflowTerminal;
	///<summary>List of materials for this cloth asset.</summary>
	public TArray<FSkeletalMaterial> Materials;
	///<summary>Skeleton asset used at creation time. This is of limited use since this USkeleton&#39;s reference skeleton might not necessarily match the one created for this asset.</summary>
	public USkeleton Skeleton;
	///<summary>Physics asset used for collision.</summary>
	public UPhysicsAsset PhysicsAsset;
	///<summary>Struct containing information for each LOD level, such as materials to use, and when use the LOD.</summary>
	public TArray<FSkeletalMeshLODInfo> LODInfo;
	///<summary>DisableBelowMinLodStripping</summary>
	public FPerPlatformBool DisableBelowMinLodStripping;
	///<summary>MinLod</summary>
	public FPerPlatformInt MinLod;
	///<summary>Enable raytracing for this asset.</summary>
	public bool bSupportRayTracing;
	///<summary>Minimum raytracing LOD for this asset.</summary>
	public int RayTracingMinLOD;
	///<summary>Whether to blend positions between the skinned/simulated transitions of the cloth render mesh.</summary>
	public bool bSmoothTransition;
	///<summary>Whether to use multiple triangle influences on the proxy wrap deformer to help smoothe deformations.</summary>
	public bool bUseMultipleInfluences;
	///<summary>The radius from which to get the multiple triangle influences from the simulated proxy mesh.</summary>
	public float SkinningKernelRadius;
	///<summary>Physics asset whose shapes will be used for shadowing when components have bCastCharacterCapsuleDirectShadow or bCastCharacterCapsuleIndirectShadow enabled.</summary>
	public UPhysicsAsset ShadowPhysicsAsset;
	///<summary>A unique identifier as used by the section rendering code.</summary>
	public FGuid AssetGuid;
}
