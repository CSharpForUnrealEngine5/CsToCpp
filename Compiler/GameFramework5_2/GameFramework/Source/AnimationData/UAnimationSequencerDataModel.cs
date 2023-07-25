#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimSequencerDataModel.h")]
public partial class UAnimationSequencerDataModel : UMovieSceneSequence {
// AnimationSequencerDataModel
	public FAnimDataModelModifiedDynamicEvent ModifiedEventDynamic;
	public FAnimationCurveData LegacyCurveData;
	public TArray<FAnimatedBoneAttribute> AnimatedBoneAttributes;
	public UMovieScene MovieScene;
	public TMap<FAnimationCurveIdentifier,FAnimationCurveMetaData> CurveIdentifierToMetaData;
	public bool bPopulated;
	public FGuid CachedRawDataGUID;
}
