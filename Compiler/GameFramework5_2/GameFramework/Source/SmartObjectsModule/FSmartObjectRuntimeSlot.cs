namespace GameFramework;
using CSharpToCpp.Utilities;
///<summary>Struct to store and manage state of a runtime instance associated to a given slot definition</summary>
[CppInclude("SmartObjectRuntime.h")]
public partial struct FSmartObjectRuntimeSlot {
	public FWorldConditionQueryState PreconditionState;
}
