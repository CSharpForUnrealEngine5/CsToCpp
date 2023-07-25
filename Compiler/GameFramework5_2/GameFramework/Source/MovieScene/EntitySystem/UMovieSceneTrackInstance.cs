#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("EntitySystem/TrackInstance/MovieSceneTrackInstance.h")]
///<summary>Base class for all track instances. Can also be used for root tracks where AnimatedObject will be nullptr</summary>
public partial class UMovieSceneTrackInstance : UObject {
// MovieSceneTrackInstance
	public UObject AnimatedObject;
	public bool bIsRootTrackInstance;
	public UMovieSceneEntitySystemLinker PrivateLinker;
	public TArray<FMovieSceneTrackInstanceInput> Inputs;
}
