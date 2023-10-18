namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("CommonNumericTextBlock.h")]
public partial struct FCommonNumberFormattingOptions {
	public ERoundingMode RoundingMode;
	public bool UseGrouping;
	public int MinimumIntegralDigits;
	public int MaximumIntegralDigits;
	public int MinimumFractionalDigits;
	public int MaximumFractionalDigits;
}
