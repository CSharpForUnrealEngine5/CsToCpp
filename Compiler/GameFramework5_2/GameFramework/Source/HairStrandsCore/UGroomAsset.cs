namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that can be used to store hair strands</summary>
[CppInclude("GroomAsset.h")]
public partial class UGroomAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>HairGroupsInfo</summary>
	public TArray<FHairGroupInfoWithVisibility> HairGroupsInfo;
	///<summary>HairGroupsRendering</summary>
	public TArray<FHairGroupsRendering> HairGroupsRendering;
	///<summary>HairGroupsPhysics</summary>
	public TArray<FHairGroupsPhysics> HairGroupsPhysics;
	///<summary>HairGroupsInterpolation</summary>
	public TArray<FHairGroupsInterpolation> HairGroupsInterpolation;
	///<summary>HairGroupsLOD</summary>
	public TArray<FHairGroupsLOD> HairGroupsLOD;
	///<summary>Cards - Source description data</summary>
	public TArray<FHairGroupsCardsSourceDescription> HairGroupsCards;
	///<summary>Meshes - Source description data</summary>
	public TArray<FHairGroupsMeshesSourceDescription> HairGroupsMeshes;
	///<summary>Meshes - Source description data</summary>
	public TArray<FHairGroupsMaterial> HairGroupsMaterials;
	///<summary>Enable radial basis function interpolation to be used instead of the local skin rigid transform (WIP)</summary>
	public bool EnableGlobalInterpolation;
	///<summary>Type of interpolation used (WIP)</summary>
	public EGroomInterpolationType HairInterpolationType;
	///<summary>Deformed skeletal mesh that will drive the groom deformation/simulation. For creating this skeletal mesh, enable EnableDeformation within the interpolation settings</summary>
	public USkeletalMesh RiggedSkeletalMesh;
	///<summary>Deformed skeletal mesh mapping from groups to sections</summary>
	public TArray<int> DeformedGroupSections;
	///<summary>Minimum LOD to cook</summary>
	public FPerPlatformInt MinLOD;
	///<summary>When true all LODs below MinLod will still be cooked</summary>
	public FPerPlatformBool DisableBelowMinLodStripping;
	///<summary>The LOD bias to use after LOD stripping, regardless of MinLOD. Computed at cook time</summary>
	public TArray<float> EffectiveLODBias;
	///<summary>Asset data to be used when re-importing</summary>
	public UAssetImportData AssetImportData;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
