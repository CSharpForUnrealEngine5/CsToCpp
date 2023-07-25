#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeographicCoordinates.h")]
public partial class UGeographicCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
// GeographicCoordinatesFunctionLibrary
	public string ToFullText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	public string ToCompactText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	public void ToSeparateTexts(FGeographicCoordinates GeographicCoordinates,string OutLatitude,string OutLongitude,string OutAltitude,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) {}
	public void ToFloatApproximation(FGeographicCoordinates GeographicCoordinates,float OutLatitude,float OutLongitude,float OutAltitude) {}
	public FGeographicCoordinates MakeGeographicCoordinatesApproximation(float InLatitude,float InLongitude,float InAltitude) { return default; }
	public FGeographicCoordinates MakeGeographicCoordinates(FVector LatLongAltVector) { return default; }
	public void ToLatLongAltVector(FGeographicCoordinates GeographicCoordinates,FVector OutLatLongAltVector) {}
}
