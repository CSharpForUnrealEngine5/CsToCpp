#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GroomBindingAsset.h")]
///<summary>Implements an asset that can be used to store binding information between a groom and a skeletal mesh</summary>
public partial class UGroomBindingAsset : UObject {
// GroomBindingAsset
	public EGroomBindingMeshType GroomBindingType;
	public UGroomAsset Groom;
	public USkeletalMesh SourceSkeletalMesh;
	public USkeletalMesh TargetSkeletalMesh;
	public UGeometryCache SourceGeometryCache;
	public UGeometryCache TargetGeometryCache;
	public int NumInterpolationPoints;
	public int MatchingSection;
	public TArray<FGoomBindingGroupInfo> GroupInfos;
}
