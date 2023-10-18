namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sequencer/MovieSceneControlRigParameterTemplate.h")]
public partial struct FMovieSceneControlRigParameterTemplate {
	public TArray<FEnumParameterNameAndCurve> Enums;
	public TArray<FIntegerParameterNameAndCurve> Integers;
	public TArray<FSpaceControlNameAndChannel> Spaces;
	public TArray<FConstraintAndActiveChannel> Constraints;
}
