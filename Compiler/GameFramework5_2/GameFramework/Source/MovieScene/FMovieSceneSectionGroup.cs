namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Structure that represents a group of sections</summary>
[CppInclude("MovieScene.h")]
public partial struct FMovieSceneSectionGroup {
	public TArray<TWeakObjectPtr<UMovieSceneSection>> Sections;
}
