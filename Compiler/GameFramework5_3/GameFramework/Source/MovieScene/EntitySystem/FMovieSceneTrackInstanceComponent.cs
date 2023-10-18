namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that defines a type for a track instance</summary>
[CppInclude("EntitySystem/BuiltInComponentTypes.h")]
public partial struct FMovieSceneTrackInstanceComponent {
	public UMovieSceneSection Owner;
	public UClass TrackInstanceClass;
}
