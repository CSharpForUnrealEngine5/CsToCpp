namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Pose Asset that can be blended by weight of curves</summary>
[CppInclude("Animation/PoseAsset.h")]
public partial class UPoseAsset : UAnimationAsset {
	public static UClass StaticClass() {return default;}
	///<summary>Animation Pose Data</summary>
	public FPoseDataContainer PoseContainer;
	///<summary>Whether or not Additive Pose or not - these are property that needs post process, so</summary>
	public bool bAdditivePose;
	///<summary>if -1, use ref pose</summary>
	public int BasePoseIndex;
	///<summary>Base pose to use when retargeting</summary>
	public string RetargetSource;
	///<summary>If RetargetSource is set to Default (None), this is asset for the base pose to use when retargeting. Transform data will be saved in RetargetSourceAssetReferencePose.</summary>
	public TSoftObjectPtr<USkeletalMesh> RetargetSourceAsset;
	///<summary>When using RetargetSourceAsset, use the post stored here</summary>
	public TArray<FTransform> RetargetSourceAssetReferencePose;
	///<summary>SourceAnimation</summary>
	public UAnimSequence SourceAnimation;
	///<summary>GUID cached when the contained poses were last updated according to SourceAnimation - used to keep track of out-of-date/sync data</summary>
	public FGuid SourceAnimationRawDataGUID;
	///<summary>Renames a specific pose</summary>
	public void RenamePose(string OriginalPoseName,string NewPoseName) {}
	///<summary>Returns the name of all contained poses</summary>
	public void GetPoseNames(TArray<string> PoseNames) {}
	///<summary>Contained poses are re-generated from the provided Animation Sequence</summary>
	public void UpdatePoseFromAnimation(UAnimSequence AnimSequence) {}
}
