namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Uses a quaternion spherical interpolation (slerp) to blend between transforms using the shortest rotation path. Does not support over-rotation.</summary>
[CppInclude("Systems/MovieSceneQuaternionBlenderSystem.h")]
public partial class UMovieSceneQuaternionBlenderSystem : UMovieSceneBlenderSystem {
	public static UClass StaticClass() {return default;}
}
