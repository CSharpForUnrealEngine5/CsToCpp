#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Evaluation/MovieSceneParameterTemplate.h")]
///<summary>Template that performs evaluation of parameter sections</summary>
public partial struct FMovieSceneParameterSectionTemplate {
// MovieSceneParameterSectionTemplate
	public TArray<FScalarParameterNameAndCurve> Scalars;
	public TArray<FBoolParameterNameAndCurve> Bools;
	public TArray<FVector2DParameterNameAndCurves> Vector2Ds;
	public TArray<FVectorParameterNameAndCurves> Vectors;
	public TArray<FColorParameterNameAndCurves> Colors;
	public TArray<FTransformParameterNameAndCurves> Transforms;
}
