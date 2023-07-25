#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimData/AnimDataModel.h")]
///<summary>The Model represents the source data for animations. It contains both bone animation data as well as animated curves.</summary>
public partial class UAnimDataModel : UObject {
// AnimDataModel
	public int BracketCounter;
	public FAnimDataModelModifiedDynamicEvent ModifiedEventDynamic;
	public TArray<FBoneAnimationTrack> BoneAnimationTracks;
	public float PlayLength;
	public FFrameRate FrameRate;
	public int NumberOfFrames;
	public int NumberOfKeys;
	public FAnimationCurveData CurveData;
	public TArray<FAnimatedBoneAttribute> AnimatedBoneAttributes;
	public bool bPopulated;
}
