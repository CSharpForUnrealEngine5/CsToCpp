namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>System responsible for tracking and animating material parameter entities.</summary>
[CppInclude("Systems/MovieSceneMaterialParameterSystem.h")]
public partial class UMovieSceneMaterialParameterSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
	///<summary>DoubleBlenderSystem</summary>
	public UMovieScenePiecewiseDoubleBlenderSystem DoubleBlenderSystem;
}
