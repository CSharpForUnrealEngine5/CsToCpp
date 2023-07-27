#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CartesianCoordinates.h")]
public partial class UCartesianCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
// CartesianCoordinatesFunctionLibrary
	public static string ToFullText(FCartesianCoordinates CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	public static string ToCompactText(FCartesianCoordinates CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	public static void ToSeparateTexts(FCartesianCoordinates CartesianCoordinates,string OutX,string OutY,string OutZ,int IntegralDigits/*=3*/) {}
	public static void ToFloatApproximation(FCartesianCoordinates CartesianCoordinates,float OutX,float OutY,float OutZ) {}
	public static FCartesianCoordinates MakeCartesianCoordinatesApproximation(float InX,float InY,float InZ) { return default; }
}
