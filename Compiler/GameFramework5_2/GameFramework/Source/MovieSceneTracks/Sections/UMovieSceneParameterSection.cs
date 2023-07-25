#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Sections/MovieSceneParameterSection.h")]
///<summary>A single movie scene section which can contain data for multiple named parameters.</summary>
public partial class UMovieSceneParameterSection : UMovieSceneSection {
// MovieSceneParameterSection
	public void AddScalarParameterKey(string InParameterName,FFrameNumber InTime,float InValue) {}
	public void AddBoolParameterKey(string InParameterName,FFrameNumber InTime,bool InValue) {}
	public void AddVector2DParameterKey(string InParameterName,FFrameNumber InTime,FVector2D InValue) {}
	public void AddVectorParameterKey(string InParameterName,FFrameNumber InTime,FVector InValue) {}
	public void AddColorParameterKey(string InParameterName,FFrameNumber InTime,FLinearColor InValue) {}
	public void AddTransformParameterKey(string InParameterName,FFrameNumber InTime,FTransform InValue) {}
	public bool RemoveScalarParameter(string InParameterName) { return default; }
	public bool RemoveBoolParameter(string InParameterName) { return default; }
	public bool RemoveVector2DParameter(string InParameterName) { return default; }
	public bool RemoveVectorParameter(string InParameterName) { return default; }
	public bool RemoveColorParameter(string InParameterName) { return default; }
	public bool RemoveTransformParameter(string InParameterName) { return default; }
	public void GetParameterNames(TSet<string> ParameterNames) {}
	public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves;
	public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves;
	public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves;
	public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves;
	public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves;
	public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves;
}
