namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Base class for all systems that blend data from multiple entities/components into a single entity</summary>
[CppInclude("EntitySystem/MovieSceneBlenderSystem.h")]
public partial class UMovieSceneBlenderSystem : UMovieSceneEntitySystem {
	public static UClass StaticClass() {return default;}
}
