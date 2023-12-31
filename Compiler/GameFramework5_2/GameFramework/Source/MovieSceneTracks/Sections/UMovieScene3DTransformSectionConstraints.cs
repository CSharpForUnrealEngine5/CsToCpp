namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This object contains information needed for constraint channels on the transform section</summary>
[CppInclude("Sections/MovieScene3DTransformSection.h")]
public partial class UMovieScene3DTransformSectionConstraints : UObject {
	public static UClass StaticClass() {return default;}
	///<summary>Constraint Channels</summary>
	public TArray<FConstraintAndActiveChannel> ConstraintsChannels;
}
