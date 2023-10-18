namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneLiveLinkStructProperties.h")]
public partial struct FLiveLinkPropertyData {
	public FName PropertyName;
	public TArray<FMovieSceneFloatChannel> FloatChannel;
	public TArray<FMovieSceneStringChannel> StringChannel;
	public TArray<FMovieSceneIntegerChannel> IntegerChannel;
	public TArray<FMovieSceneBoolChannel> BoolChannel;
	public TArray<FMovieSceneByteChannel> ByteChannel;
}
