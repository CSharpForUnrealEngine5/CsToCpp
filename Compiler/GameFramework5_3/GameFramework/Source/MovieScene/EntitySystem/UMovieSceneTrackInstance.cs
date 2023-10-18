namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all track instances. Can also be used for root tracks where AnimatedObject will be nullptr</summary>
[CppInclude("EntitySystem/TrackInstance/MovieSceneTrackInstance.h")]
public partial class UMovieSceneTrackInstance : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>WeakAnimatedObject</summary>
	public TWeakObjectPtr<UObject> WeakAnimatedObject;
	///<summary>bIsRootTrackInstance</summary>
	public bool bIsRootTrackInstance;
	///<summary>PrivateLinker</summary>
	public UMovieSceneEntitySystemLinker PrivateLinker;
	///<summary>Inputs</summary>
	public TArray<FMovieSceneTrackInstanceInput> Inputs;
}
