#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>This object contains information needed for constraint channels on the transform section</summary>
[CppInclude("Sections/MovieScene3DTransformSection.h")]
public partial class UMovieScene3DTransformSectionConstraints : UObject {
	///<summary>Constraint Channels</summary>
	public TArray<FConstraintAndActiveChannel> ConstraintsChannels;
}
