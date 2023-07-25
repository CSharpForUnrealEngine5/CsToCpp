#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/IAnimationDataModel.h")]
///<summary>Structure encapsulating a single bone animation track.</summary>
public partial struct FBoneAnimationTrack {
// BoneAnimationTrack
	public FRawAnimSequenceTrack InternalTrackData;
	public int BoneTreeIndex;
	public string Name;
}
