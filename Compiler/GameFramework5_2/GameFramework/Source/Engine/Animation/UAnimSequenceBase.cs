#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Animation/AnimSequenceBase.h")]
public partial class UAnimSequenceBase : UAnimationAsset {
	///<summary>Animation notifies, sorted by time (earliest notification first).</summary>
	public TArray<FAnimNotifyEvent> Notifies;
	///<summary>SequenceLength</summary>
	public float SequenceLength;
	///<summary>RawCurveData</summary>
	public FRawCurveTracks RawCurveData;
	///<summary>Number for tweaking playback rate of this animation globally.</summary>
	public float RateScale;
	///<summary>The default looping behavior of this animation.</summary>
	public bool bLoop;
	///<summary>if you change Notifies array, this will need to be rebuilt</summary>
	public TArray<FAnimNotifyTrack> AnimNotifyTracks;
	///<summary>DataModel</summary>
	public UAnimDataModel DataModel;
	///<summary>IAnimationDataModel instance containing (source) animation data</summary>
	public object /*DataModelInterface*/ DataModelInterface;
	///<summary>UAnimDataController instance set to operate on DataModel</summary>
	public object /*Controller*/ Controller;
}
