#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Movie Scene section for Lens Component</summary>
[CppInclude("MovieSceneLensComponentSection.h")]
public partial class UMovieSceneLensComponentSection : UMovieSceneHookSection {
	public static UClass StaticClass() {return default;}
	///<summary>If true, then every Update, the nodal offset will be re-evaluated on the lens component</summary>
	public bool bReapplyNodalOffset;
	///<summary>LensFile asset that should be used instead of the cached LensFile during playback</summary>
	public ULensFile OverrideLensFile;
	///<summary>Saved duplicate of the LensFile asset used by the recorded Lens Component at the time of recording</summary>
	public ULensFile CachedLensFile;
	///<summary>Channels to store Distortion Parameter values (will be sized during initialization based on the LensComponent&#39;s LensModel)</summary>
	public TArray<FMovieSceneFloatChannel> DistortionParameterChannels;
	///<summary>Channels to store FxFy values</summary>
	public TArray<FMovieSceneFloatChannel> FxFyChannels;
	///<summary>Channels to store Image Center values</summary>
	public TArray<FMovieSceneFloatChannel> ImageCenterChannels;
	///<summary>The Lens Model used by the recorded LensComponent</summary>
	public UClass LensModelClass;
}
