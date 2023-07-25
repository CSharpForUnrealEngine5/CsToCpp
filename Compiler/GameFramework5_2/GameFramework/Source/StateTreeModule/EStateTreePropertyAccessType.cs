#pragma warning disable CS8618,CS8603
namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>The type of access a property path describes.</summary>
public enum EStateTreePropertyAccessType {
	Offset=0,
	Object=1,
	WeakObject=2,
	SoftObject=3,
	IndexArray=4,
}
