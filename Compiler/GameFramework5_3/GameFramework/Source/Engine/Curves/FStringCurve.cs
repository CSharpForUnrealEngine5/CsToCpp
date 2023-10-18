namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Implements a curve of FStrings.</summary>
[CppInclude("Curves/StringCurve.h")]
public partial struct FStringCurve {
	public string DefaultValue;
	public TArray<FStringCurveKey> Keys;
}
