#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Simple type of sequence for use in automated tests.</summary>
[CppInclude("Tests/MovieSceneTestDataBuilders.h")]
public partial class UMovieSceneTestSequence : UMovieSceneSequence {
	///<summary>The movie scene</summary>
	public UMovieScene MovieScene;
	///<summary>BoundObjects</summary>
	public TArray<UObject> BoundObjects;
	///<summary>BindingGuids</summary>
	public TArray<FGuid> BindingGuids;
}
