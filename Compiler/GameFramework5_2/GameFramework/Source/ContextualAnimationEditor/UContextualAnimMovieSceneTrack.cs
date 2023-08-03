#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ContextualAnimMovieSceneTrack.h")]
public partial class UContextualAnimMovieSceneTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>List of sections in this track</summary>
	public TArray<UMovieSceneSection> Sections;
	///<summary>Role this track represents</summary>
	public string Role;
}
