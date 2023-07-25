#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigParameterSection.h")]
///<summary>Movie scene section that controls animation controller animation</summary>
public partial class UMovieSceneControlRigParameterSection : UMovieSceneParameterSection {
// MovieSceneControlRigParameterSection
	public UControlRig ControlRig;
	public UClass ControlRigClass;
	public TArray<bool> ControlsMask;
	public FMovieSceneTransformMask TransformMask;
	public FMovieSceneFloatChannel Weight;
	public TMap<string,FChannelMapInfo> ControlChannelMap;
	public TArray<FEnumParameterNameAndCurve> EnumParameterNamesAndCurves;
	public TArray<FIntegerParameterNameAndCurve> IntegerParameterNamesAndCurves;
	public TArray<FSpaceControlNameAndChannel> SpaceChannels;
	public TArray<FConstraintAndActiveChannel> ConstraintsChannels;
}
