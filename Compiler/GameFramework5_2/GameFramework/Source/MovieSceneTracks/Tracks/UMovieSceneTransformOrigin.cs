namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Tracks/IMovieSceneTransformOrigin.h")]
public partial class UMovieSceneTransformOrigin : UInterface {
	public static UClass StaticClass() {return default;}
	///<summary>Get the transform from which all absolute component transform sections should be relative. Scale is ignored.</summary>
	public FTransform BP_GetTransformOrigin() { return default; }
}
