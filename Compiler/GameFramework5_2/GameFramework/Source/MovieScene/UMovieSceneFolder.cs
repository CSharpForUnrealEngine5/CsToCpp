#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneFolder.h")]
///<summary>Represents a folder used for organizing objects in tracks in a movie scene.</summary>
public partial class UMovieSceneFolder : UObject {
// MovieSceneFolder
	public string FolderName;
	public TArray<UMovieSceneFolder> ChildFolders;
	public TArray<UMovieSceneTrack> ChildTracks;
	public TArray<string> ChildObjectBindingStrings;
	public FColor FolderColor;
	public int SortingOrder;
	public TArray<UMovieSceneTrack> ChildMasterTracks_DEPRECATED;
}
