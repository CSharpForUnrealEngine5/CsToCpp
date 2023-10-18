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
	///<summary>HairGroupsCards</summary>
	public TArray<FHairGroupsCardsSourceDescription> HairGroupsCards;
	///<summary>HairGroupsMeshes</summary>
	public TArray<FHairGroupsMeshesSourceDescription> HairGroupsMeshes;
	///<summary>HairGroupsMaterials</summary>
	public TArray<FHairGroupsMaterial> HairGroupsMaterials;
	///<summary>Enable radial basis function interpolation to be used instead of the local skin rigid transform (WIP)</summary>
	public bool EnableGlobalInterpolation;
	///<summary>Enable guide-cache support. This allows to attach a simulation-cache dynamically at runtime</summary>
	public bool EnableSimulationCache;
	///<summary>Type of interpolation used (WIP)</summary>
	public EGroomInterpolationType HairInterpolationType;
	///<summary>RiggedSkeletalMesh</summary>
	public USkeletalMesh RiggedSkeletalMesh;
	///<summary>DeformedGroupSections</summary>
	public TArray<int> DeformedGroupSections;
	///<summary>MinLOD</summary>
	public FPerPlatformInt MinLOD;
	///<summary>DisableBelowMinLodStripping</summary>
	public FPerPlatformBool DisableBelowMinLodStripping;
	///<summary>EffectiveLODBias</summary>
	public TArray<float> EffectiveLODBias;
	///<summary>GetHairGroupsRendering</summary>
	public TArray<FHairGroupsRendering> GetHairGroupsRendering() { return default; }
	///<summary>SetHairGroupsRendering</summary>
	public void SetHairGroupsRendering(TArray<FHairGroupsRendering> In) {}
	///<summary>GetHairGroupsPhysics</summary>
	public TArray<FHairGroupsPhysics> GetHairGroupsPhysics() { return default; }
	///<summary>SetHairGroupsPhysics</summary>
	public void SetHairGroupsPhysics(TArray<FHairGroupsPhysics> In) {}
	///<summary>GetHairGroupsInterpolation</summary>
	public TArray<FHairGroupsInterpolation> GetHairGroupsInterpolation() { return default; }
	///<summary>SetHairGroupsInterpolation</summary>
	public void SetHairGroupsInterpolation(TArray<FHairGroupsInterpolation> In) {}
	///<summary>GetHairGroupsLOD</summary>
	public TArray<FHairGroupsLOD> GetHairGroupsLOD() { return default; }
	///<summary>SetHairGroupsLOD</summary>
	public void SetHairGroupsLOD(TArray<FHairGroupsLOD> In) {}
	///<summary>GetHairGroupsCards</summary>
	public TArray<FHairGroupsCardsSourceDescription> GetHairGroupsCards() { return default; }
	///<summary>SetHairGroupsCards</summary>
	public void SetHairGroupsCards(TArray<FHairGroupsCardsSourceDescription> In) {}
	///<summary>GetHairGroupsMeshes</summary>
	public TArray<FHairGroupsMeshesSourceDescription> GetHairGroupsMeshes() { return default; }
	///<summary>SetHairGroupsMeshes</summary>
	public void SetHairGroupsMeshes(TArray<FHairGroupsMeshesSourceDescription> In) {}
	///<summary>GetHairGroupsMaterials</summary>
	public TArray<FHairGroupsMaterial> GetHairGroupsMaterials() { return default; }
	///<summary>SetHairGroupsMaterials</summary>
	public void SetHairGroupsMaterials(TArray<FHairGroupsMaterial> In) {}
	///<summary>GetEnableGlobalInterpolation</summary>
	public bool GetEnableGlobalInterpolation() { return default; }
	///<summary>SetEnableGlobalInterpolation</summary>
	public void SetEnableGlobalInterpolation(bool In) {}
	///<summary>GetEnableSimulationCache</summary>
	public bool GetEnableSimulationCache() { return default; }
	///<summary>SetEnableSimulationCache</summary>
	public void SetEnableSimulationCache(bool In) {}
	///<summary>GetHairInterpolationType</summary>
	public EGroomInterpolationType GetHairInterpolationType() { return default; }
	///<summary>SetHairInterpolationType</summary>
	public void SetHairInterpolationType(EGroomInterpolationType In) {}
	///<summary>GetRiggedSkeletalMesh</summary>
	public USkeletalMesh GetRiggedSkeletalMesh() { return default; }
	///<summary>SetRiggedSkeletalMesh</summary>
	public void SetRiggedSkeletalMesh(USkeletalMesh In) {}
	///<summary>GetDeformedGroupSections</summary>
	public TArray<int> GetDeformedGroupSections() { return default; }
	///<summary>SetDeformedGroupSections</summary>
	public void SetDeformedGroupSections(TArray<int> In) {}
	///<summary>Asset data to be used when re-importing</summary>
	public UAssetImportData AssetImportData;
	///<summary>Array of user data stored with the asset</summary>
	public TArray<UAssetUserData> AssetUserData;
}
