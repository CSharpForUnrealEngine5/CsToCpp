namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>MovieSceneSpawnable describes an object that can be spawned for this MovieScene</summary>
[CppInclude("MovieSceneSpawnable.h")]
public partial struct FMovieSceneSpawnable {
	public FTransform SpawnTransform;
	public TArray<string> Tags;
	public bool bContinuouslyRespawn;
	public bool bNetAddressableName;
	public bool bEvaluateTracksWhenNotSpawned;
	public FGuid Guid;
	public string Name;
	public UObject ObjectTemplate;
	public TArray<FGuid> ChildPossessables;
	public ESpawnOwnership Ownership;
	public UClass GeneratedClass_DEPRECATED;
	public string LevelName;
}
