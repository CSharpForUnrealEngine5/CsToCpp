namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A frame rate represented as a fraction comprising 2 integers: a numerator (number of frames), and a denominator (per second).</summary>
[CppInclude("UObject/NoExportTypes.h")]
public partial struct FFrameRate {
	public int Numerator;
	public int Denominator;
}
