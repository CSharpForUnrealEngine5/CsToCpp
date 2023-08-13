namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to hold reference to a StateTree asset along with values to parameterized it.</summary>
[CppInclude("StateTreeReference.h")]
public partial struct FStateTreeReference {
	public UStateTree StateTree;
	public FInstancedPropertyBag Parameters;
}
