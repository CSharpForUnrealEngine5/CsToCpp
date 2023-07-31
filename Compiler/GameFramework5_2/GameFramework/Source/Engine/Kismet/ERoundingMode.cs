#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("Kismet/KismetTextLibrary.h")]
///<summary>Provides rounding modes for converting numbers into localized text</summary>
public enum ERoundingMode {
	HalfToEven=0,
	HalfFromZero=1,
	HalfToZero=2,
	FromZero=3,
	ToZero=4,
	ToNegativeInfinity=5,
	ToPositiveInfinity=6,
}
