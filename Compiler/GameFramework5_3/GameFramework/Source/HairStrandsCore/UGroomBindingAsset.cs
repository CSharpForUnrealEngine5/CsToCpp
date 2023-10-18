namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements an asset that can be used to store binding information between a groom and a skeletal mesh</summary>
[CppInclude("GroomBindingAsset.h")]
public partial class UGroomBindingAsset : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>GroomBindingType</summary>
	public EGroomBindingMeshType GroomBindingType;
	///<summary>GetGroomBindingType</summary>
	public EGroomBindingMeshType GetGroomBindingType() { return default; }
	///<summary>SetGroomBindingType</summary>
	public void SetGroomBindingType(EGroomBindingMeshType InGroomBindingType) {}
	///<summary>Groom</summary>
	public UGroomAsset Groom;
	///<summary>GetGroom</summary>
	public UGroomAsset GetGroom() { return default; }
	///<summary>SetGroom</summary>
	public void SetGroom(UGroomAsset InGroom) {}
	///<summary>SourceSkeletalMesh</summary>
	public USkeletalMesh SourceSkeletalMesh;
	///<summary>GetSourceSkeletalMesh</summary>
	public USkeletalMesh GetSourceSkeletalMesh() { return default; }
	///<summary>SetSourceSkeletalMesh</summary>
	public void SetSourceSkeletalMesh(USkeletalMesh InSkeletalMesh) {}
	///<summary>TargetSkeletalMesh</summary>
	public USkeletalMesh TargetSkeletalMesh;
	///<summary>GetTargetSkeletalMesh</summary>
	public USkeletalMesh GetTargetSkeletalMesh() { return default; }
	///<summary>SetTargetSkeletalMesh</summary>
	public void SetTargetSkeletalMesh(USkeletalMesh InSkeletalMesh) {}
	///<summary>SourceGeometryCache</summary>
	public UGeometryCache SourceGeometryCache;
	///<summary>GetSourceGeometryCache</summary>
	public UGeometryCache GetSourceGeometryCache() { return default; }
	///<summary>SetSourceGeometryCache</summary>
	public void SetSourceGeometryCache(UGeometryCache InGeometryCache) {}
	///<summary>TargetGeometryCache</summary>
	public UGeometryCache TargetGeometryCache;
	///<summary>GetTargetGeometryCache</summary>
	public UGeometryCache GetTargetGeometryCache() { return default; }
	///<summary>SetTargetGeometryCache</summary>
	public void SetTargetGeometryCache(UGeometryCache InGeometryCache) {}
	///<summary>NumInterpolationPoints</summary>
	public int NumInterpolationPoints;
	///<summary>GetNumInterpolationPoints</summary>
	public int GetNumInterpolationPoints() { return default; }
	///<summary>SetNumInterpolationPoints</summary>
	public void SetNumInterpolationPoints(int InNumInterpolationPoints) {}
	///<summary>MatchingSection</summary>
	public int MatchingSection;
	///<summary>GetMatchingSection</summary>
	public int GetMatchingSection() { return default; }
	///<summary>SetMatchingSection</summary>
	public void SetMatchingSection(int InMatchingSection) {}
	///<summary>GroupInfos</summary>
	public TArray<FGoomBindingGroupInfo> GroupInfos;
	///<summary>GetGroupInfos</summary>
	public TArray<FGoomBindingGroupInfo> GetGroupInfos() { return default; }
	///<summary>SetGroupInfos</summary>
	public void SetGroupInfos(TArray<FGoomBindingGroupInfo> InGroupInfos) {}
}
