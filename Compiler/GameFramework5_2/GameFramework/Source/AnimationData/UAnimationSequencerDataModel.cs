#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("AnimSequencerDataModel.h")]
public partial class UAnimationSequencerDataModel : UMovieSceneSequence {
	public static UClass StaticClass() {return default;}
	///<summary>Dynamic delegate event allows scripting to register to any broadcast-ed notify.</summary>
	public FAnimDataModelModifiedDynamicEvent ModifiedEventDynamic;
	///<summary>LegacyCurveData</summary>
	public FAnimationCurveData LegacyCurveData;
	///<summary>AnimatedBoneAttributes</summary>
	public TArray<FAnimatedBoneAttribute> AnimatedBoneAttributes;
	///<summary>Movie scene instance containing FK Control rig and section representing the animation data</summary>
	public UMovieScene MovieScene;
	///<summary>Per-curve information holding flags/color, due to be deprecated in the future</summary>
	public TMap<FAnimationCurveIdentifier,FAnimationCurveMetaData> CurveIdentifierToMetaData;
	///<summary>bPopulated</summary>
	public bool bPopulated;
	///<summary>Raw data GUID taken from UAnimSequence when initially populating - this allows for retaining compressed data state initially</summary>
	public FGuid CachedRawDataGUID;
}
