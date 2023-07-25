#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequenceBase.h")]
public partial class UAnimSequenceBase : UAnimationAsset {
// AnimSequenceBase
	public TArray<FAnimNotifyEvent> Notifies;
	public float SequenceLength;
	public FRawCurveTracks RawCurveData;
	public float RateScale;
	public bool bLoop;
	public TArray<FAnimNotifyTrack> AnimNotifyTracks;
	public UAnimDataModel DataModel;
	public object /*DataModelInterface*/ DataModelInterface;
	public object /*Controller*/ Controller;
}
