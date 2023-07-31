#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint function library to convert geospatial coordinates to text</summary>
[CppInclude("GeoReferencingBFL.h")]
public partial class UGeoReferencingBFL : UBlueprintFunctionLibrary {
	///<summary>Converts a LargeCoordinates value to localized formatted text, in the form &#39;X= Y= Z=&#39;</summary>
	public static string ToFullText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>Converts a LargeCoordinates value to formatted text, in the form &#39;(X, Y, Z)&#39;</summary>
	public static string ToCompactText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>Converts a LargeCoordinates value to 3 separate text values</summary>
	public static void ToSeparateTexts(FVector CartesianCoordinates,string OutX,string OutY,string OutZ,int IntegralDigits/*=3*/) {}
}
