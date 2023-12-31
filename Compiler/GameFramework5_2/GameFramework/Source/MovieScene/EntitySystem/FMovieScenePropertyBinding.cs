namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Source property binding information for an entity on a moviescene timeline</summary>
[CppInclude("EntitySystem/MovieScenePropertyBinding.h")]
public partial struct FMovieScenePropertyBinding {
	public FName PropertyName;
	public FName PropertyPath;
	public bool bCanUseClassLookup;
}
