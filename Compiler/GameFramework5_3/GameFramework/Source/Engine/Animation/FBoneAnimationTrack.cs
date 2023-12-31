namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure encapsulating a single bone animation track.</summary>
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
public partial struct FBoneAnimationTrack {
	public FRawAnimSequenceTrack InternalTrackData;
	public int BoneTreeIndex;
	public FName Name;
}
