#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Handles animation of ChaosCache</summary>
[CppInclude("Chaos/Sequencer/MovieSceneChaosCacheTrack.h")]
public partial class UMovieSceneChaosCacheTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all animation sections</summary>
	public TArray<UMovieSceneSection> AnimationSections;
}
