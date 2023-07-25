#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Systems/MovieScenePropertySystem.h")]
///<summary>Abstract base class for any property system that deals with a property registered with FBuiltInComponentTypes::PropertyRegistry</summary>
public partial class UMovieScenePropertySystem : UMovieSceneEntitySystem {
// MovieScenePropertySystem
	public UMovieScenePropertyInstantiatorSystem InstantiatorSystem;
}
