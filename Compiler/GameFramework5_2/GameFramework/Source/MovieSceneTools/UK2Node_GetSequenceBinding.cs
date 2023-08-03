#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("K2Node_GetSequenceBinding.h")]
public partial class UK2Node_GetSequenceBinding : UK2Node {
	public static UClass StaticClass() {return default;}
	///<summary>The sequence from which to choose a binding identifier</summary>
	public FSoftObjectPath SourceSequence;
	///<summary>The user-selected literal binding identifier from the sequence to use</summary>
	public FMovieSceneObjectBindingID Binding;
}
