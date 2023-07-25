#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigParameterTemplate.h")]
public partial struct FMovieSceneControlRigParameterTemplate {
// MovieSceneControlRigParameterTemplate
	public TArray<FEnumParameterNameAndCurve> Enums;
	public TArray<FIntegerParameterNameAndCurve> Integers;
	public TArray<FSpaceControlNameAndChannel> Spaces;
	public TArray<FConstraintAndActiveChannel> Constraints;
}
