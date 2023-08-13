namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for tracks that animate an object property</summary>
[CppInclude("Tracks/MovieScenePropertyTrack.h")]
public partial class UMovieScenePropertyTrack : UMovieSceneNameableTrack {
	public static UClass StaticClass() {return default;}
	///<summary>Unique name for this track to afford multiple tracks on a given object (i.e. for array properties)</summary>
	public string UniqueTrackName;
	///<summary>Name of the property being changed</summary>
	public string PropertyName_DEPRECATED;
	///<summary>Path to the property from the source object being changed</summary>
	public string PropertyPath_DEPRECATED;
	///<summary>Section we should Key</summary>
	public UMovieSceneSection SectionToKey;
	///<summary>PropertyBinding</summary>
	public FMovieScenePropertyBinding PropertyBinding;
	///<summary>All the sections in this list</summary>
	public TArray<UMovieSceneSection> Sections;
}
