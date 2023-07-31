#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single movie scene section which can contain data for multiple named parameters.</summary>
[CppInclude("Sections/MovieSceneParameterSection.h")]
public partial class UMovieSceneParameterSection : UMovieSceneSection {
	///<summary>Adds a a key for a specific scalar parameter at the specified time with the specified value.</summary>
	public  void AddScalarParameterKey(string InParameterName,FFrameNumber InTime,float InValue) {}
	///<summary>Adds a a key for a specific bool parameter at the specified time with the specified value.</summary>
	public  void AddBoolParameterKey(string InParameterName,FFrameNumber InTime,bool InValue) {}
	///<summary>Adds a a key for a specific vector2D parameter at the specified time with the specified value.</summary>
	public  void AddVector2DParameterKey(string InParameterName,FFrameNumber InTime,FVector2D InValue) {}
	///<summary>Adds a a key for a specific vector parameter at the specified time with the specified value.</summary>
	public  void AddVectorParameterKey(string InParameterName,FFrameNumber InTime,FVector InValue) {}
	///<summary>Adds a a key for a specific color parameter at the specified time with the specified value.</summary>
	public  void AddColorParameterKey(string InParameterName,FFrameNumber InTime,FLinearColor InValue) {}
	///<summary>Adds a a key for a specific color parameter at the specified time with the specified value.</summary>
	public  void AddTransformParameterKey(string InParameterName,FFrameNumber InTime,FTransform InValue) {}
	///<summary>Removes a scalar parameter from this section.</summary>
	public  bool RemoveScalarParameter(string InParameterName) { return default; }
	///<summary>Removes a bool parameter from this section.</summary>
	public  bool RemoveBoolParameter(string InParameterName) { return default; }
	///<summary>Removes a vector2D parameter from this section.</summary>
	public  bool RemoveVector2DParameter(string InParameterName) { return default; }
	///<summary>Removes a vector parameter from this section.</summary>
	public  bool RemoveVectorParameter(string InParameterName) { return default; }
	///<summary>Removes a color parameter from this section.</summary>
	public  bool RemoveColorParameter(string InParameterName) { return default; }
	///<summary>Removes a transform parameter from this section.</summary>
	public  bool RemoveTransformParameter(string InParameterName) { return default; }
	///<summary>Gets the set of all parameter names used by this section.</summary>
	public  void GetParameterNames(TSet<string> ParameterNames) {}
	///<summary>The bool parameter names and their associated curves.</summary>
	public TArray<FBoolParameterNameAndCurve> BoolParameterNamesAndCurves;
	///<summary>The scalar parameter names and their associated curves.</summary>
	public TArray<FScalarParameterNameAndCurve> ScalarParameterNamesAndCurves;
	///<summary>The vector3D parameter names and their associated curves.</summary>
	public TArray<FVector2DParameterNameAndCurves> Vector2DParameterNamesAndCurves;
	///<summary>The vector parameter names and their associated curves.</summary>
	public TArray<FVectorParameterNameAndCurves> VectorParameterNamesAndCurves;
	///<summary>The color parameter names and their associated curves.</summary>
	public TArray<FColorParameterNameAndCurves> ColorParameterNamesAndCurves;
	///<summary>The transform  parameter names and their associated curves.</summary>
	public TArray<FTransformParameterNameAndCurves> TransformParameterNamesAndCurves;
}
