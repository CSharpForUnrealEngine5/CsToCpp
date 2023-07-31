#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A component that defines a type for a track instance</summary>
[CppInclude("EntitySystem/BuiltInComponentTypes.h")]
public partial struct FMovieSceneTrackInstanceComponent {
	public UMovieSceneSection Owner;
	public UClass TrackInstanceClass;
}
