#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreeReference.h")]
///<summary>Struct to hold reference to a StateTree asset along with values to parameterized it.</summary>
public partial struct FStateTreeReference {
// StateTreeReference
	public UStateTree StateTree;
	public FInstancedPropertyBag Parameters;
}
