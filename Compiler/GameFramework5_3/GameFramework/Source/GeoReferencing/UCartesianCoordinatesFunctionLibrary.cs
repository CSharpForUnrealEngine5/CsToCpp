namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CartesianCoordinates.h")]
public partial class UCartesianCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>ToFullText</summary>
	public static FText ToFullText(FCartesianCoordinates CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>ToCompactText</summary>
	public static FText ToCompactText(FCartesianCoordinates CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>ToSeparateTexts</summary>
	public static void ToSeparateTexts(FCartesianCoordinates CartesianCoordinates,FText OutX,FText OutY,FText OutZ,int IntegralDigits/*=3*/) {}
	///<summary>ToFloatApproximation</summary>
	public static void ToFloatApproximation(FCartesianCoordinates CartesianCoordinates,float OutX,float OutY,float OutZ) {}
	///<summary>MakeCartesianCoordinatesApproximation</summary>
	public static FCartesianCoordinates MakeCartesianCoordinatesApproximation(float InX,float InY,float InZ) { return default; }
}
