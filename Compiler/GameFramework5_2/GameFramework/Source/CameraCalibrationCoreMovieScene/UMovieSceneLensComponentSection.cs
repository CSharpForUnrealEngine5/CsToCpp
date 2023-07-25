#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneLensComponentSection.h")]
///<summary>Movie Scene section for Lens Component</summary>
public partial class UMovieSceneLensComponentSection : UMovieSceneHookSection {
// MovieSceneLensComponentSection
	public bool bReapplyNodalOffset;
	public ULensFile OverrideLensFile;
	public ULensFile CachedLensFile;
	public TArray<FMovieSceneFloatChannel> DistortionParameterChannels;
	public TArray<FMovieSceneFloatChannel> FxFyChannels;
	public TArray<FMovieSceneFloatChannel> ImageCenterChannels;
	public UClass LensModelClass;
}
