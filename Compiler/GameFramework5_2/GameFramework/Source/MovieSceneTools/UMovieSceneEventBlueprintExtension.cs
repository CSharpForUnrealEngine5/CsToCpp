namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("MovieSceneEventBlueprintExtension.h")]
public partial class UMovieSceneEventBlueprintExtension : UBlueprintExtension {
	public static UClass StaticClass() {return default;}
	///<summary>List of event sections that are bound to the blueprint</summary>
	public TArray<TWeakObjectPtr<UMovieSceneEventSectionBase>> EventSections;
}
