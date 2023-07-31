#pragma warning disable CS8618,CS8603,CS1587,CS1591
namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to hold reference to a StateTree asset along with values to parameterized it.</summary>
[CppInclude("StateTreeReference.h")]
public partial struct FStateTreeReference {
	public UStateTree StateTree;
	public FInstancedPropertyBag Parameters;
}
