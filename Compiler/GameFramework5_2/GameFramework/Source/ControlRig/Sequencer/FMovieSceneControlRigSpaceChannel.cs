#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigSpaceChannel.h")]
///<summary>A curve of spaces</summary>
public partial struct FMovieSceneControlRigSpaceChannel {
// MovieSceneControlRigSpaceChannel
	public TArray<FFrameNumber> KeyTimes;
	public TArray<FMovieSceneControlRigSpaceBaseKey> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
