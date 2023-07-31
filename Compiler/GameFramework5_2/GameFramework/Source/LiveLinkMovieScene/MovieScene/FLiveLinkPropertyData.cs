#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieScene/MovieSceneLiveLinkStructProperties.h")]
public partial struct FLiveLinkPropertyData {
	public string PropertyName;
	public TArray<FMovieSceneFloatChannel> FloatChannel;
	public TArray<FMovieSceneStringChannel> StringChannel;
	public TArray<FMovieSceneIntegerChannel> IntegerChannel;
	public TArray<FMovieSceneBoolChannel> BoolChannel;
	public TArray<FMovieSceneByteChannel> ByteChannel;
}
