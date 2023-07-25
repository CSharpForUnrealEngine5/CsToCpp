#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomAsset.h")]
///<summary>Implements an asset that can be used to store hair strands</summary>
public partial class UGroomAsset : UObject {
// GroomAsset
	public TArray<FHairGroupInfoWithVisibility> HairGroupsInfo;
	public TArray<FHairGroupsRendering> HairGroupsRendering;
	public TArray<FHairGroupsPhysics> HairGroupsPhysics;
	public TArray<FHairGroupsInterpolation> HairGroupsInterpolation;
	public TArray<FHairGroupsLOD> HairGroupsLOD;
	public TArray<FHairGroupsCardsSourceDescription> HairGroupsCards;
	public TArray<FHairGroupsMeshesSourceDescription> HairGroupsMeshes;
	public TArray<FHairGroupsMaterial> HairGroupsMaterials;
	public bool EnableGlobalInterpolation;
	public EGroomInterpolationType HairInterpolationType;
	public USkeletalMesh RiggedSkeletalMesh;
	public TArray<int> DeformedGroupSections;
	public FPerPlatformInt MinLOD;
	public FPerPlatformBool DisableBelowMinLodStripping;
	public TArray<float> EffectiveLODBias;
	public UAssetImportData AssetImportData;
	public TArray<UAssetUserData> AssetUserData;
}
