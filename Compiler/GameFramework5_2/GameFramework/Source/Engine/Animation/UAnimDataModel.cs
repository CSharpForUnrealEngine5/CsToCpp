#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>The Model represents the source data for animations. It contains both bone animation data as well as animated curves.</summary>
[CppInclude("Animation/AnimData/AnimDataModel.h")]
public partial class UAnimDataModel : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>BracketCounter</summary>
	public int BracketCounter;
	///<summary>Dynamic delegate event allows scripting to register to any broadcasted notify.</summary>
	public FAnimDataModelModifiedDynamicEvent ModifiedEventDynamic;
	///<summary>All individual bone animation tracks</summary>
	public TArray<FBoneAnimationTrack> BoneAnimationTracks;
	///<summary>PlayLength</summary>
	public float PlayLength;
	///<summary>Rate at which the animated data is sampled</summary>
	public FFrameRate FrameRate;
	///<summary>Total number of sampled animated frames</summary>
	public int NumberOfFrames;
	///<summary>Total number of sampled animated keys</summary>
	public int NumberOfKeys;
	///<summary>Container with all animated curve data</summary>
	public FAnimationCurveData CurveData;
	///<summary>Container with all animated (bone) attribute data</summary>
	public TArray<FAnimatedBoneAttribute> AnimatedBoneAttributes;
	///<summary>bPopulated</summary>
	public bool bPopulated;
}
