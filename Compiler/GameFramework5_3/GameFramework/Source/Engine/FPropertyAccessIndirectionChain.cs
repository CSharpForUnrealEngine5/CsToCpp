namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A single property access list. This is a list of FPropertyAccessIndirection</summary>
[CppInclude("PropertyAccess.h")]
public partial struct FPropertyAccessIndirectionChain {
	public object Property;
	public int IndirectionStartIndex;
	public int IndirectionEndIndex;
}
