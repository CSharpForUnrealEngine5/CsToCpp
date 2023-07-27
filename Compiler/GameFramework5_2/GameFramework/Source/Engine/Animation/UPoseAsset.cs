#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/PoseAsset.h")]
///<summary>Pose Asset that can be blended by weight of curves</summary>
public partial class UPoseAsset : UAnimationAsset {
// PoseAsset
	public FPoseDataContainer PoseContainer;
	public bool bAdditivePose;
	public int BasePoseIndex;
	public string RetargetSource;
	public TSoftObjectPtr<USkeletalMesh> RetargetSourceAsset;
	public TArray<FTransform> RetargetSourceAssetReferencePose;
	public UAnimSequence SourceAnimation;
	public FGuid SourceAnimationRawDataGUID;
	public  void RenamePose(string OriginalPoseName,string NewPoseName) {}
	public  void GetPoseNames(TArray<string> PoseNames) {}
	public  void UpdatePoseFromAnimation(UAnimSequence AnimSequence) {}
}
