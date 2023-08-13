namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a folder used for organizing objects in tracks in a movie scene.</summary>
[CppInclude("MovieSceneFolder.h")]
public partial class UMovieSceneFolder : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>The name of this folder.</summary>
	public string FolderName;
	///<summary>The folders contained by this folder.</summary>
	public TArray<UMovieSceneFolder> ChildFolders;
	///<summary>The tracks contained by this folder.</summary>
	public TArray<UMovieSceneTrack> ChildTracks;
	///<summary>The guid strings used to serialize the guids for the object bindings contained by this folder.</summary>
	public TArray<string> ChildObjectBindingStrings;
	///<summary>This folder&#39;s color</summary>
	public FColor FolderColor;
	///<summary>This folder&#39;s desired sorting order</summary>
	public int SortingOrder;
	///<summary>ChildMasterTracks_DEPRECATED</summary>
	public TArray<UMovieSceneTrack> ChildMasterTracks_DEPRECATED;
}
