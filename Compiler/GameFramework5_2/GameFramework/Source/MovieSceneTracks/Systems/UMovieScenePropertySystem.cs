#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Abstract base class for any property system that deals with a property registered with FBuiltInComponentTypes::PropertyRegistry</summary>
[CppInclude("Systems/MovieScenePropertySystem.h")]
public partial class UMovieScenePropertySystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
	///<summary>Pointer to the property instantiator system for retrieving property stats</summary>
	public UMovieScenePropertyInstantiatorSystem InstantiatorSystem;
}
