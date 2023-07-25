#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneBinding.h")]
///<summary>A set of tracks bound to runtime objects</summary>
public partial struct FMovieSceneBinding {
// MovieSceneBinding
	public FGuid ObjectGuid;
	public string BindingName;
	public TArray<UMovieSceneTrack> Tracks;
	public int SortingOrder;
}
