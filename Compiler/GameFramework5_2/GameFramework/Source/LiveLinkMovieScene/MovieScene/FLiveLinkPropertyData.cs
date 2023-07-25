#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneLiveLinkStructProperties.h")]
public partial struct FLiveLinkPropertyData {
// LiveLinkPropertyData
	public string PropertyName;
	public TArray<FMovieSceneFloatChannel> FloatChannel;
	public TArray<FMovieSceneStringChannel> StringChannel;
	public TArray<FMovieSceneIntegerChannel> IntegerChannel;
	public TArray<FMovieSceneBoolChannel> BoolChannel;
	public TArray<FMovieSceneByteChannel> ByteChannel;
}
