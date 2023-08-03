#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie scene section that controls animation controller animation</summary>
[CppInclude("Sequencer/MovieSceneControlRigParameterSection.h")]
public partial class UMovieSceneControlRigParameterSection : UMovieSceneParameterSection {
	public static UClass StaticClass() {return default;}
	///<summary>Control Rig that controls us</summary>
	public UControlRig ControlRig;
	///<summary>The class of control rig to instantiate</summary>
	public UClass ControlRigClass;
	///<summary>Mask for controls themselves</summary>
	public TArray<bool> ControlsMask;
	///<summary>Mask for Transform Mask</summary>
	public FMovieSceneTransformMask TransformMask;
	///<summary>The weight curve for this animation controller section</summary>
	public FMovieSceneFloatChannel Weight;
	///<summary>Map from the control name to where it starts as a channel</summary>
	public TMap<string,FChannelMapInfo> ControlChannelMap;
	///<summary>Enum Curves</summary>
	public TArray<FEnumParameterNameAndCurve> EnumParameterNamesAndCurves;
	///<summary>Integer Curves</summary>
	public TArray<FIntegerParameterNameAndCurve> IntegerParameterNamesAndCurves;
	///<summary>Space Channels</summary>
	public TArray<FSpaceControlNameAndChannel> SpaceChannels;
	///<summary>Space Channels</summary>
	public TArray<FConstraintAndActiveChannel> ConstraintsChannels;
}
