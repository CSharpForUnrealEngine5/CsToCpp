namespace GameFramework;
using CSharpToCpp.Utilities;
[CppInclude("StateTreePropertyBindings.h")]
///<summary>The type of access a property path describes.</summary>
public enum EStateTreePropertyAccessType {
	Offset=0,
	Object=1,
	WeakObject=2,
	SoftObject=3,
	ObjectInstance=4,
	StructInstance=5,
	IndexArray=6,
}
