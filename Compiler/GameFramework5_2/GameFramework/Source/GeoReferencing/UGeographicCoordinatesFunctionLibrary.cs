#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeographicCoordinates.h")]
public partial class UGeographicCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
// GeographicCoordinatesFunctionLibrary
	public static string ToFullText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	public static string ToCompactText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	public static void ToSeparateTexts(FGeographicCoordinates GeographicCoordinates,string OutLatitude,string OutLongitude,string OutAltitude,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) {}
	public static void ToFloatApproximation(FGeographicCoordinates GeographicCoordinates,float OutLatitude,float OutLongitude,float OutAltitude) {}
	public static FGeographicCoordinates MakeGeographicCoordinatesApproximation(float InLatitude,float InLongitude,float InAltitude) { return default; }
	public static FGeographicCoordinates MakeGeographicCoordinates(FVector LatLongAltVector) { return default; }
	public static void ToLatLongAltVector(FGeographicCoordinates GeographicCoordinates,FVector OutLatLongAltVector) {}
}
