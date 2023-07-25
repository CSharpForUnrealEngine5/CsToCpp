#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Channels/MovieSceneByteChannel.h")]
public partial struct FMovieSceneByteChannel {
// MovieSceneByteChannel
	public TArray<FFrameNumber> Times;
	public byte DefaultValue;
	public bool bHasDefaultValue;
	public TArray<byte> Values;
	public UEnum Enum;
	public FMovieSceneKeyHandleMap KeyHandles;
}
