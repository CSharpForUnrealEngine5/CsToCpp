#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeographicCoordinates.h")]
public partial class UGeographicCoordinatesFunctionLibrary : UBlueprintFunctionLibrary {
	///<summary>Converts a GeographicCoordinates value to localized formatted text, in the form &#39;X= Y= Z=&#39;</summary>
	public static string ToFullText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	///<summary>Converts a GeographicCoordinates value to formatted text, in the form &#39;(X, Y, Z)&#39;</summary>
	public static string ToCompactText(FGeographicCoordinates GeographicCoordinates,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) { return default; }
	///<summary>Converts a GeographicCoordinates value to 3 separate text values</summary>
	public static void ToSeparateTexts(FGeographicCoordinates GeographicCoordinates,string OutLatitude,string OutLongitude,string OutAltitude,int IntegralDigitsLatLon/*=8*/,int IntegralDigitsAlti/*=2*/,bool bAsDMS/*=false*/) {}
	///<summary>ToFloatApproximation</summary>
	public static void ToFloatApproximation(FGeographicCoordinates GeographicCoordinates,float OutLatitude,float OutLongitude,float OutAltitude) {}
	///<summary>MakeGeographicCoordinatesApproximation</summary>
	public static FGeographicCoordinates MakeGeographicCoordinatesApproximation(float InLatitude,float InLongitude,float InAltitude) { return default; }
	///<summary>Make Geographic Coordinates from a FVector where X=Latitude, Y=Longitude, Z=Altitude</summary>
	public static FGeographicCoordinates MakeGeographicCoordinates(FVector LatLongAltVector) { return default; }
	///<summary>Express the Geographic coordinates as a FVector where  where X=Latitude, Y=Longitude, Z=Altitude</summary>
	public static void ToLatLongAltVector(FGeographicCoordinates GeographicCoordinates,FVector OutLatLongAltVector) {}
}
