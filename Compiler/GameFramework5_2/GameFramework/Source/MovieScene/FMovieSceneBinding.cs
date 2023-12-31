namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A set of tracks bound to runtime objects</summary>
[CppInclude("MovieSceneBinding.h")]
public partial struct FMovieSceneBinding {
	public FGuid ObjectGuid;
	public string BindingName;
	public TArray<UMovieSceneTrack> Tracks;
	public int SortingOrder;
}
