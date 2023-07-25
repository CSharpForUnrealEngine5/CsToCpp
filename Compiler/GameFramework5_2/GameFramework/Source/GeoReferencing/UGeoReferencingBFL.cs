#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("GeoReferencingBFL.h")]
///<summary>Blueprint function library to convert geospatial coordinates to text</summary>
public partial class UGeoReferencingBFL : UBlueprintFunctionLibrary {
// GeoReferencingBFL
	public string ToFullText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	public string ToCompactText(FVector CartesianCoordinates,int IntegralDigits/*=3*/) { return default; }
	public void ToSeparateTexts(FVector CartesianCoordinates,string OutX,string OutY,string OutZ,int IntegralDigits/*=3*/) {}
}
