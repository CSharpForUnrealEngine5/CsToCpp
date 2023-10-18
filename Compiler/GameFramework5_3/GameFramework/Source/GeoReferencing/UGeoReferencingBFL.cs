namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Blueprint function library to convert geospatial coordinates to text</summary>
[CppInclude("GeoReferencingBFL.h")]
public partial class UGeoReferencingBFL : UBlueprintFunctionLibrary {
	public static UClass StaticClass() {return default;}
	///<summary>Converts a LargeCoordinates value to localized formatted text, in the form &#39;X= Y= Z=&#39;</summary>
	public static FText ToFullText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>Converts a LargeCoordinates value to formatted text, in the form &#39;(X, Y, Z)&#39;</summary>
	public static FText ToCompactText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	///<summary>Converts a LargeCoordinates value to 3 separate text values</summary>
	public static void ToSeparateTexts(FVector CartesianCoordinates,FText OutX,FText OutY,FText OutZ,int IntegralDigits/*=3*/) {}
}
