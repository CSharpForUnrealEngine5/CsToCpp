namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>A curve base class which enables key handles to index lookups.</summary>
[CppInclude("Curves/IndexedCurve.h")]
public partial struct FIndexedCurve {
	public FKeyHandleMap KeyHandlesToIndices;
}
