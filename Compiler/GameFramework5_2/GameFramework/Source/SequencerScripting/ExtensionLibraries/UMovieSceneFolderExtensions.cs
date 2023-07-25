#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneFolderExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneFolders for scripting</summary>
public partial class UMovieSceneFolderExtensions : UBlueprintFunctionLibrary {
// MovieSceneFolderExtensions
	public string GetFolderName(UObject Folder) { return default; }
	public bool SetFolderName(UObject Folder,string InFolderName) { return default; }
	public FColor GetFolderColor(UObject Folder) { return default; }
	public bool SetFolderColor(UObject Folder,FColor InFolderColor) { return default; }
	public TArray<UObject> GetChildFolders(UObject Folder) { return default; }
	public bool AddChildFolder(UObject TargetFolder,UObject FolderToAdd) { return default; }
	public bool RemoveChildFolder(UObject TargetFolder,UObject FolderToRemove) { return default; }
	public TArray<UObject> GetChildTracks(UObject Folder) { return default; }
	public TArray<UObject> GetChildMasterTracks(UObject Folder) { return default; }
	public bool AddChildTrack(UObject Folder,UObject InTrack) { return default; }
	public bool AddChildMasterTrack(UObject Folder,UObject InTrack) { return default; }
	public bool RemoveChildTrack(UObject Folder,UObject InTrack) { return default; }
	public bool RemoveChildMasterTrack(UObject Folder,UObject InTrack) { return default; }
	public TArray<FMovieSceneBindingProxy> GetChildObjectBindings(UObject Folder) { return default; }
	public bool AddChildObjectBinding(UObject Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
	public bool RemoveChildObjectBinding(UObject Folder,FMovieSceneBindingProxy InObjectBinding) { return default; }
}
