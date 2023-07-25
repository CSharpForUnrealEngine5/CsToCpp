#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("ExtensionLibraries/MovieSceneTrackExtensions.h")]
///<summary>Function library containing methods that should be hoisted onto UMovieSceneTracks for scripting</summary>
public partial class UMovieSceneTrackExtensions : UBlueprintFunctionLibrary {
// MovieSceneTrackExtensions
	public void SetDisplayName(UObject Track,string InName) {}
	public string GetDisplayName(UObject Track) { return default; }
	public void SetTrackRowDisplayName(UObject Track,string InName,int RowIndex) {}
	public string GetTrackRowDisplayName(UObject Track,int RowIndex) { return default; }
	public UObject AddSection(UObject Track) { return default; }
	public TArray<UObject> GetSections(UObject Track) { return default; }
	public void RemoveSection(UObject Track,UObject Section) {}
	public int GetSortingOrder(UObject Track) { return default; }
	public void SetSortingOrder(UObject Track,int SortingOrder) {}
	public FColor GetColorTint(UObject Track) { return default; }
	public void SetColorTint(UObject Track,FColor ColorTint) {}
	public UObject GetSectionToKey(UObject Track) { return default; }
	public void SetSectionToKey(UObject Track,UObject Section) {}
}
