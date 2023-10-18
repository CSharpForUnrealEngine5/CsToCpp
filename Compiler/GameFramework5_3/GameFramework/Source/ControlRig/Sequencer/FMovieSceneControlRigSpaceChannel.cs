namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A curve of spaces</summary>
[CppInclude("Sequencer/MovieSceneControlRigSpaceChannel.h")]
public partial struct FMovieSceneControlRigSpaceChannel {
	public TArray<FFrameNumber> KeyTimes;
	public TArray<FMovieSceneControlRigSpaceBaseKey> KeyValues;
	public FMovieSceneKeyHandleMap KeyHandles;
}
