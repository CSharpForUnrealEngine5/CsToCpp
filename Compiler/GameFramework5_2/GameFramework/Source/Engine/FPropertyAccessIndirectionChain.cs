#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("PropertyAccess.h")]
///<summary>A single property access list. This is a list of FPropertyAccessIndirection</summary>
public partial struct FPropertyAccessIndirectionChain {
// PropertyAccessIndirectionChain
	public object Property;
	public int IndirectionStartIndex;
	public int IndirectionEndIndex;
}
