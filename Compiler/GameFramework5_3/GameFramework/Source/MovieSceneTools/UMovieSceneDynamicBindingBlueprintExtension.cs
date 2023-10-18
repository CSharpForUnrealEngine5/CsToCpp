namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>An extension for a sequence&#39;s director blueprint to compile dynamic binding endpoints.</summary>
[CppInclude("MovieSceneDynamicBindingBlueprintExtension.h")]
public partial class UMovieSceneDynamicBindingBlueprintExtension : UBlueprintExtension {
	public static UClass StaticClass() {return default;}
	///<summary>List of movie scenes that are bound to the director blueprint</summary>
	public TArray<TWeakObjectPtr<UMovieSceneSequence>> WeakMovieSceneSequences;
	///<summary>The movie scene that is bound to the director blueprint</summary>
	public TWeakObjectPtr<UMovieSceneSequence> WeakMovieSceneSequence_DEPRECATED;
}
