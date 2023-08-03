#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Function library containing methods that should be hoisted onto UMovieSceneFolders for scripting</summary>
[CppInclude("ExtensionLibraries/MovieSceneFolderExtensions.h")]
public partial class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Get the given folder&#39;s display name</summary>
	public static string GetFolderName(UMovieSceneFolder Folder) { return default; }
	///<summary>Set the name of the given folder</summary>
	public static bool SetFolderName(UMovieSceneFolder Folder,string InFolderName) { return default; }
	///<summary>Get the display color of the given folder</summary>
	public static FColor GetFolderColor(UMovieSceneFolder Folder) { return default; }
	///<summary>Set the display color of the given folder</summary>
	public static bool SetFolderColor(UMovieSceneFolder Folder,FColor InFolderColor) { return default; }
	///<summary>Get the child folders of a given folder</summary>
	public static TArray<UMovieSceneFolder> GetChildFolders(UMovieSceneFolder Folder) { return default; }
	///<summary>Add a child folder to the target folder</summary>
	public static bool AddChildFolder(UMovieSceneFolder TargetFolder,UMovieSceneFolder FolderToAdd) { return default; }
	///<summary>Remove a child folder from the given folder</summary>
	public static bool RemoveChildFolder(UMovieSceneFolder TargetFolder,UMovieSceneFolder FolderToRemove) { return default; }
	///<summary>Get the tracks contained by this folder</summary>
	public static TArray<UMovieSceneTrack> GetChildTracks(UMovieSceneFolder Folder) { return default; }
	///<summary>GetChildMasterTracks</summary>
	public static TArray<UMovieSceneTrack> GetChildMasterTracks(UMovieSceneFolder Folder) { return default; }
	///<summary>Add a track to this folder</summary>
	public static bool AddChildTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	///<summary>AddChildMasterTrack</summary>
	public static bool AddChildMasterTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	///<summary>Remove a track from the given folder</summary>
	public static bool RemoveChildTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	///<summary>RemoveChildMasterTrack</summary>
	public static bool RemoveChildMasterTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	///<summary>Get the object bindings contained by this folder</summary>
	public static TArray<FMovieSceneBindingProxy> GetChildObjectBindings(UMovieSceneFolder Folder) { return default; }
	///<summary>Add a guid for an object binding to this folder</summary>
	public static bool AddChildObjectBinding(UMovieSceneFolder Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
	///<summary>Remove an object binding from the given folder</summary>
	public static bool RemoveChildObjectBinding(UMovieSceneFolder Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
}
