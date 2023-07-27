#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneFolderExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneFolders for scripting</summary>
public partial class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary {
// MovieSceneFolderExtensions
	public static string GetFolderName(UMovieSceneFolder Folder) { return default; }
	public static bool SetFolderName(UMovieSceneFolder Folder,string InFolderName) { return default; }
	public static FColor GetFolderColor(UMovieSceneFolder Folder) { return default; }
	public static bool SetFolderColor(UMovieSceneFolder Folder,FColor InFolderColor) { return default; }
	public static TArray<UMovieSceneFolder> GetChildFolders(UMovieSceneFolder Folder) { return default; }
	public static bool AddChildFolder(UMovieSceneFolder TargetFolder,UMovieSceneFolder FolderToAdd) { return default; }
	public static bool RemoveChildFolder(UMovieSceneFolder TargetFolder,UMovieSceneFolder FolderToRemove) { return default; }
	public static TArray<UMovieSceneTrack> GetChildTracks(UMovieSceneFolder Folder) { return default; }
	public static TArray<UMovieSceneTrack> GetChildMasterTracks(UMovieSceneFolder Folder) { return default; }
	public static bool AddChildTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	public static bool AddChildMasterTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	public static bool RemoveChildTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	public static bool RemoveChildMasterTrack(UMovieSceneFolder Folder,UMovieSceneTrack InTrack) { return default; }
	public static TArray<FMovieSceneBindingProxy> GetChildObjectBindings(UMovieSceneFolder Folder) { return default; }
	public static bool AddChildObjectBinding(UMovieSceneFolder Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
	public static bool RemoveChildObjectBinding(UMovieSceneFolder Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
}
