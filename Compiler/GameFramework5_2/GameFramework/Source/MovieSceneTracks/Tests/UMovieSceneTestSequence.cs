#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tests/MovieSceneTestDataBuilders.h")]
///<summary>Simple type of sequence for use in automated tests.</summary>
public partial class UMovieSceneTestSequence : UMovieSceneSequence {
// MovieSceneTestSequence
	public UMovieScene MovieScene;
	public TArray<UObject> BoundObjects;
	public TArray<FGuid> BindingGuids;
}
