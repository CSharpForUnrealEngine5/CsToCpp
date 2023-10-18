namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Template that performs evaluation of parameter sections</summary>
[CppInclude("Evaluation/MovieSceneParameterTemplate.h")]
public partial struct FMovieSceneParameterSectionTemplate {
	public TArray<FScalarParameterNameAndCurve> Scalars;
	public TArray<FBoolParameterNameAndCurve> Bools;
	public TArray<FVector2DParameterNameAndCurves> Vector2Ds;
	public TArray<FVectorParameterNameAndCurves> Vectors;
	public TArray<FColorParameterNameAndCurves> Colors;
	public TArray<FTransformParameterNameAndCurves> Transforms;
}
