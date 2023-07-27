#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("LevelSequenceDirector.h")]
public partial class ULevelSequenceDirector : UObject {
// LevelSequenceDirector
	public  void OnCreated() {}
	public  FQualifiedFrameTime GetRootSequenceTime() { return default; }
	public  FQualifiedFrameTime GetMasterSequenceTime() { return default; }
	public  FQualifiedFrameTime GetCurrentTime() { return default; }
	public  TArray<UObject> GetBoundObjects(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public  UObject GetBoundObject(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public  TArray<AActor> GetBoundActors(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public  AActor GetBoundActor(FMovieSceneObjectBindingID ObjectBinding) { return default; }
	public  UMovieSceneSequence GetSequence() { return default; }
	public ULevelSequencePlayer Player;
	public int SubSequenceID;
	public int MovieScenePlayerIndex;
}
