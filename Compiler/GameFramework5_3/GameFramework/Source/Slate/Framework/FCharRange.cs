namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Represents a range of characters, specified by the Unicode code point of the first and last characters in the range, both included.</summary>
[CppInclude("Framework/Text/CharRangeList.h")]
public partial struct FCharRange {
	public ushort First;
	public ushort Last;
}
