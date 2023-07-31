#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A curve of spaces</summary>
[CppInclude("Sequencer/MovieSceneControlRigSpaceChannel.h")]
public partial struct FMovieSceneControlRigSpaceChannel {
	public TArray<FFrameNumber> KeyTimes;
	public TArray<FMovieSceneControlRigSpaceBaseKey> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
