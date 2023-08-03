#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for constraint tracks (tracks that are dependent upon other objects).</summary>
[CppInclude("Tracks/MovieScene3DConstraintTrack.h")]
public partial class UMovieScene3DConstraintTrack : UMovieSceneTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of all constraint sections.</summary>
	public TArray<UMovieSceneSection> ConstraintSections;
}
